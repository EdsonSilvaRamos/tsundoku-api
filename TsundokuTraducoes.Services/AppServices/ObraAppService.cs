﻿using AutoMapper;
using FluentResults;
using TsundokuTraducoes.Domain.Interfaces.Services;
using TsundokuTraducoes.Entities.Entities.Obra;
using TsundokuTraducoes.Helpers;
using TsundokuTraducoes.Services.AppServices.Interfaces;
using TsundokuTraducoes.Helpers.DTOs.Admin;
using TsundokuTraducoes.Helpers.DTOs.Admin.Retorno;

#nullable disable

namespace TsundokuTraducoes.Services.AppServices
{
    public class ObraAppService : IObraAppService
    {
        private readonly IMapper _mapper;
        private readonly IObraService _obraservice;
        private readonly IImagemAppService _imagemAppService;
        private readonly IGeneroDeParaAppService _generoDeParaAppService;

        public ObraAppService(IMapper mapper, IObraService obraservice, IImagemAppService imagemAppService, IGeneroDeParaAppService generoDeParaAppService)
        {
            _mapper = mapper;
            _obraservice = obraservice;
            _imagemAppService = imagemAppService;
            _generoDeParaAppService = generoDeParaAppService;
        }

        public async Task<Result<List<RetornoObra>>> RetornaListaObras()
        {
            var listaRetornoObras = new List<RetornoObra>();
            var listaNovels = await RetornaListaNovels();
            var listaComics = await RetornaListaComics();

            listaRetornoObras.AddRange(listaNovels.Value);
            listaRetornoObras.AddRange(listaComics.Value);

            return Result.Ok(listaRetornoObras);
        }

        public async Task<Result<List<RetornoObra>>> RetornaListaNovels()
        {
            var listaRetornoObras = new List<RetornoObra>();
            var listaNovels = await _obraservice.RetornaListaNovels();

            if (listaNovels.Count > 0)
            {
                foreach (var obra in listaNovels)
                {
                    listaRetornoObras.Add(await TrataRetornoNovel(obra));
                }
            }

            return Result.Ok(listaRetornoObras);
        }

        public async Task<Result<List<RetornoObra>>> RetornaListaComics()
        {
            var listaRetornoObras = new List<RetornoObra>();
            var listaComics = await _obraservice.RetornaListaComics();

            if (listaComics.Count > 0)
            {
                foreach (var comic in listaComics)
                {
                    listaRetornoObras.Add(await TrataRetornoComic(comic));
                }
            }

            return Result.Ok(listaRetornoObras);
        }

        public async Task<Result<RetornoObra>> RetornaNovelPorId(Guid id)
        {
            var novel = await _obraservice.RetornaNovelPorId(id);
            if (novel == null)
                return Result.Fail("Novel não encontrada!");

            var retornoNovel = await TrataRetornoNovel(novel);
            return Result.Ok().ToResult(retornoNovel);
        }
        
        public async Task<Result<RetornoObra>> RetornaComicPorId(Guid id)
        {
            var comic = await _obraservice.RetornaComicPorId(id);
            if (comic == null)
                return Result.Fail("Comic não encontrada!");

            var retornoComic = await TrataRetornoComic(comic);
            return Result.Ok().ToResult(retornoComic);
        }
        
        
        public async Task<Result<RetornoObra>> AdicionaNovel(ObraDTO obraDTO)
        {
            if (!ValidaDadosRequestObra(obraDTO))
                return Result.Fail("Verifique os campos obrigatórios e tente adicionar novamente!");

            var novelExistente = await _obraservice.RetornaNovelExistente(obraDTO.Titulo);

            if (novelExistente != null)
                return Result.Fail("Novel já postada!");

            if (!TratamentoDeStrings.ValidaCorHexaDecimal(obraDTO.CodigoCorHexaObra))
                return Result.Fail("Erro ao adicionar a Novel, código hexadecimal informada fora do padrão!");            

            if (obraDTO.ImagemCapaPrincipalFile != null)
            {
                var result = _imagemAppService.ProcessaUploadCapaObra(obraDTO);
                if (result.IsFailed)
                    return Result.Fail(result.Errors[0].Message);
            }
            else
            {
                return Result.Fail("Erro ao adicionar a Obra, imagem da capa não enviada!");
            }

            if (obraDTO.ImagemBannerFile != null)
            {
                var result = _imagemAppService.ProcessaUploadBannerObra(obraDTO);
                if (result.IsFailed)
                    return Result.Fail(result.Errors[0].Message);
            }
            
            var novel = _mapper.Map<Novel>(obraDTO);
            
            novel.DataInclusao = DateTime.Now;
            novel.DataAlteracao = novel.DataInclusao;
            novel.DiretorioImagemObra = obraDTO.DiretorioImagemObra;
            novel.ImagemCapaPrincipal = obraDTO.ImagemCapaPrincipal;
            novel.ImagemBanner = obraDTO.ImagemBanner;

            var novelCriada = await _obraservice.AdicionaNovel(novel);
            if (!novelCriada)
                return Result.Fail("Erro ao adicionar a Novel!");

            await _obraservice.InsereGenerosNovel(novel, obraDTO.ListaGeneros, true);

            var retornoObra = await TrataRetornoNovel(novel);
            return Result.Ok().ToResult(retornoObra);
        }
        
        public async Task<Result<RetornoObra>> AdicionaComic(ObraDTO obraDTO)
        {
            if (!ValidaDadosRequestObra(obraDTO))
                return Result.Fail("Verifique os campos obrigatórios e tente adicionar novamente!");

            var comicExistente = await _obraservice.RetornaComicExistente(obraDTO.Titulo);

            if (comicExistente != null)
                return Result.Fail("Comic já postada!");

            if (!TratamentoDeStrings.ValidaCorHexaDecimal(obraDTO.CodigoCorHexaObra))
                return Result.Fail("Erro ao adicionar a Comic, código hexadecimal informada fora do padrão!");

            if (obraDTO.ImagemCapaPrincipalFile != null)
            {
                var result = _imagemAppService.ProcessaUploadCapaObra(obraDTO);
                if (result.IsFailed)
                    return Result.Fail(result.Errors[0].Message);
            }
            else
            {
                return Result.Fail("Erro ao adicionar a Comic, imagem da capa não enviada!");
            }

            if (obraDTO.ImagemBannerFile != null)
            {
                var result = _imagemAppService.ProcessaUploadBannerObra(obraDTO);
                if (result.IsFailed)
                    return Result.Fail(result.Errors[0].Message);
            }

            var comic = _mapper.Map<Comic>(obraDTO);

            comic.DataInclusao = DateTime.Now;
            comic.DataAlteracao = comic.DataInclusao;
            comic.DiretorioImagemObra = obraDTO.DiretorioImagemObra;
            comic.ImagemCapaPrincipal = obraDTO.ImagemCapaPrincipal;
            comic.ImagemBanner = obraDTO.ImagemBanner;

            var comicAdicionada = await _obraservice.AdicionaComic(comic);
            if (!comicAdicionada)
                return Result.Fail("Erro ao adicionar a Comic!");

            await _obraservice.InsereGenerosComic(comic, obraDTO.ListaGeneros, true);

            var retornoObra = await TrataRetornoComic(comic);
            return Result.Ok().ToResult(retornoObra);
        }

        
        public async Task<Result<RetornoObra>> AtualizaNovel(ObraDTO obraDTO)
        {
            var novelEncontrada = await _obraservice.RetornaNovelPorId(obraDTO.Id);
            if (novelEncontrada == null)
                return Result.Fail("Novel não encontrada!");

            if (!TratamentoDeStrings.ValidaCorHexaDecimal(obraDTO.CodigoCorHexaObra))
                return Result.Fail("Erro ao atualizar a Novel, código hexadecimal informada fora do padrão!");

            if (obraDTO.ImagemCapaPrincipalFile != null)
            {
                var result = _imagemAppService.ProcessaUploadCapaObra(obraDTO);
                if (result.IsFailed)
                    return Result.Fail(result.Errors[0].Message);
            }
            else
            {
                obraDTO.ImagemCapaPrincipal = novelEncontrada.ImagemCapaPrincipal;
            }

            if (obraDTO.ImagemBannerFile != null)
            {
                var result = _imagemAppService.ProcessaUploadBannerObra(obraDTO);
                if (result.IsFailed)
                    return Result.Fail(result.Errors[0].Message);
            }
            else
            {
                obraDTO.ImagemBanner = novelEncontrada.ImagemBanner;
            }

            novelEncontrada.ImagemCapaPrincipal = obraDTO.ImagemCapaPrincipal;
            novelEncontrada.ImagemBanner = obraDTO.ImagemBanner;
            novelEncontrada = _obraservice.AtualizaNovel(obraDTO);

            var novelAtualizada = await _obraservice.AlteracoesSalvas();

            if (!novelAtualizada)
                return Result.Fail("Erro ao atualizar a Novel!");

            await _obraservice.InsereGenerosNovel(novelEncontrada, obraDTO.ListaGeneros, false);

            var retornoObra = await TrataRetornoNovel(novelEncontrada);
            return Result.Ok().ToResult(retornoObra);

            throw new NotImplementedException();
        }       
        
        public async Task<Result<RetornoObra>> AtualizaComic(ObraDTO obraDTO)
        {
            var comicEncontrada = await _obraservice.RetornaComicPorId(obraDTO.Id);
            if (comicEncontrada == null)
                return Result.Fail("Obra não encontrada!");

            if (!TratamentoDeStrings.ValidaCorHexaDecimal(obraDTO.CodigoCorHexaObra))
                return Result.Fail("Erro ao atualizar a Obra, código hexadecimal informada fora do padrão!");

            if (obraDTO.ImagemCapaPrincipalFile != null)
            {
                var result = _imagemAppService.ProcessaUploadCapaObra(obraDTO);
                if (result.IsFailed)
                    return Result.Fail(result.Errors[0].Message);
            }
            else
            {
                obraDTO.ImagemCapaPrincipal = comicEncontrada.ImagemCapaPrincipal;
            }

            if (obraDTO.ImagemBannerFile != null)
            {
                var result = _imagemAppService.ProcessaUploadBannerObra(obraDTO);
                if (result.IsFailed)
                    return Result.Fail(result.Errors[0].Message);
            }
            else
            {
                obraDTO.ImagemBanner = comicEncontrada.ImagemBanner;
            }

            comicEncontrada.ImagemCapaPrincipal = obraDTO.ImagemCapaPrincipal;
            comicEncontrada.ImagemBanner = obraDTO.ImagemBanner;
            comicEncontrada = _obraservice.AtualizaComic(obraDTO);

            var comicAtualizada = await _obraservice.AlteracoesSalvas();

            if (!comicAtualizada)
                return Result.Fail("Erro ao atualizar a obra!");

            await _obraservice.InsereGenerosComic(comicEncontrada, obraDTO.ListaGeneros, false);

            var retornoObra = await TrataRetornoComic(comicEncontrada);
            return Result.Ok().ToResult(retornoObra);
        }


        public async Task<Result<bool>> ExcluiNovel(Guid idObra)
        {
            var novelEncontrada = await _obraservice.RetornaNovelPorId(idObra);
            if (novelEncontrada == null)
                return Result.Fail("Novel não encontrada!");

            var novelExcluida = await _obraservice.ExcluiNovel(novelEncontrada);
            _imagemAppService.ExcluiDiretorioImagens(novelEncontrada.DiretorioImagemObra);

            if (!novelExcluida)
                return Result.Fail("Erro ao excluir a Novel!");

            return Result.Ok().WithSuccess("Novel excluída com sucesso!");
        }
        
        public async Task<Result<bool>> ExcluiComic(Guid idObra)
        {
            var comicEncontrada = await _obraservice.RetornaComicPorId(idObra);
            if (comicEncontrada == null)
                return Result.Fail("Comic não encontrada!");

            var comicExcluida = await _obraservice.ExcluiComic(comicEncontrada);
            _imagemAppService.ExcluiDiretorioImagens(comicEncontrada.DiretorioImagemObra);

            if (!comicExcluida)
                return Result.Fail("Erro ao excluir a Comic!");

            return Result.Ok().WithSuccess("Comic excluída com sucesso!");
        }


        private async Task<RetornoObra> TrataRetornoNovel(Novel novel)
        {
            var retornoNovel = _mapper.Map<RetornoObra>(novel);
            retornoNovel.DataInclusao = novel.DataInclusao.ToString("dd/MM/yyyy HH:mm:ss");
            retornoNovel.UsuarioAlteracao = !string.IsNullOrEmpty(novel.UsuarioAlteracao) ? novel.UsuarioAlteracao : "";
            retornoNovel.DataAlteracao = novel.DataAlteracao.ToString("dd/MM/yyyy HH:mm:ss");
            retornoNovel.Generos = await _generoDeParaAppService.CarregaListaGenerosNovel(novel.GenerosNovel);
            return retornoNovel;
        }

        private async Task<RetornoObra> TrataRetornoComic(Comic comic)
        {
            var retornoObra = _mapper.Map<RetornoObra>(comic);
            retornoObra.DataInclusao = comic.DataInclusao.ToString("dd/MM/yyyy HH:mm:ss");
            retornoObra.UsuarioAlteracao = !string.IsNullOrEmpty(comic.UsuarioAlteracao) ? comic.UsuarioAlteracao : "";
            retornoObra.DataAlteracao = comic.DataAlteracao.ToString("dd/MM/yyyy HH:mm:ss");
            retornoObra.Generos = await _generoDeParaAppService.CarregaListaGenerosComic(comic.GenerosComic);
            return retornoObra;
        }

        private bool ValidaDadosRequestObra(ObraDTO obraDTO)
        {
            var resquestValido = VerificaString(obraDTO.Titulo) &&
                VerificaString(obraDTO.Alias) &&
                VerificaString(obraDTO.TituloAlternativo) &&
                VerificaString(obraDTO.Autor) &&
                VerificaString(obraDTO.Ano) &&
                VerificaString(obraDTO.UsuarioInclusao) &&
                VerificaString(obraDTO.Sinopse) &&
                VerificaString(obraDTO.CodigoCorHexaObra) &&
                VerificaString(obraDTO.NacionalidadeSlug) &&
                VerificaString(obraDTO.StatusObraSlug) &&
                VerificaString(obraDTO.TipoObraSlug) &&
                obraDTO.ListaGeneros.Count > 0 &&
                obraDTO.ImagemCapaPrincipalFile != null;

            return resquestValido;
        }

        private bool VerificaString(string valor)
        {            
            return !string.IsNullOrEmpty(valor) && !valor.Contains("\"\""); ;
        }
    }
}
