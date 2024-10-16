﻿using Microsoft.EntityFrameworkCore;
using TsundokuTraducoes.Data.Context;
using TsundokuTraducoes.Domain.Interfaces.Repositories;
using TsundokuTraducoes.Entities.Entities.DePara;
using TsundokuTraducoes.Entities.Entities.Generos;
using TsundokuTraducoes.Entities.Entities.Obra;
using TsundokuTraducoes.Helpers;
using TsundokuTraducoes.Helpers.DTOs.Admin;

namespace TsundokuTraducoes.Data.Repositories
{
    public class ObraRepository : IObraRepository
    {
        private readonly IGeneroDeParaRepository _generoDeParaRepository;
        private readonly IGeneroRepository _generoRepository;
        protected readonly ContextBase _context;

        public ObraRepository(ContextBase context, IGeneroDeParaRepository generoDeParaRepository, IGeneroRepository generoRepository)
        {
            _generoDeParaRepository = generoDeParaRepository;
            _generoRepository = generoRepository;
            _context = context;
        }

        public List<Novel> RetornaListaNovels()
        {
            return _context.Novels.AsNoTracking().Include(n => n.GenerosNovel).ToList();
        }
        
        public List<Comic> RetornaListaComics()
        {
            return _context.Comics.AsNoTracking().Include(n => n.GenerosComic).ToList();
        }


        public Novel RetornaNovelPorId(Guid novelId)
        {
            var listaNovels = RetornaListaNovels();
            return listaNovels.SingleOrDefault(f => f.Id == novelId);
        }

        public Comic RetornaComicPorId(Guid comicId)
        {
            var listaComics = RetornaListaComics();
            return listaComics.SingleOrDefault(f => f.Id == comicId);
        }


        public async Task AdicionaNovel(Novel novel)
        {
            await _context.AddAsync(novel);
        }

        public async Task AdicionaComic(Comic comic)
        {
            await _context.AddAsync(comic);
        }


        public Novel AtualizaNovel(ObraDTO obraDTO)
        {
            var novelEncontrada = _context.Novels.Include(n => n.GenerosNovel).SingleOrDefault(n => n.Id == obraDTO.Id);
            obraDTO.DiretorioImagemObra = novelEncontrada.DiretorioImagemObra;
            _context.Entry(novelEncontrada).CurrentValues.SetValues(obraDTO);
            novelEncontrada.DataAlteracao = DateTime.Now;

            return novelEncontrada;
        }

        public Comic AtualizaComic(ObraDTO obraDTO)
        {
            var comicEncontrada = _context.Comics.Include(o => o.GenerosComic).SingleOrDefault(o => o.Id == obraDTO.Id);
            obraDTO.DiretorioImagemObra = comicEncontrada.DiretorioImagemObra;
            _context.Entry(comicEncontrada).CurrentValues.SetValues(obraDTO);
            comicEncontrada.DataAlteracao = DateTime.Now;

            return comicEncontrada;
        }


        public void ExcluiNovel(Novel novel)
        {
            _context.Remove(novel);
        }

        public void ExcluiComic(Comic comic)
        {
            _context.Remove(comic);
        }


        public Novel RetornaNovelExistente(string titulo)
        {   
            return _context.Novels.AsNoTracking().Where(w => EF.Functions.Like(w.Titulo, titulo)).FirstOrDefault();
        }

        public Comic RetornaComicExistente(string titulo)
        {
            return _context.Comics.AsNoTracking().Where(w => EF.Functions.Like(w.Titulo, titulo)).FirstOrDefault();
        }


        public async Task InsereGenerosNovel(Novel novel, List<string> listaGeneros, bool inclusao)
        {
            if (inclusao)
            {
                novel.GenerosNovel = new List<GeneroNovel>();
            }
            else
            {
                foreach (var generoNovel in novel.GenerosNovel)
                {
                    _generoDeParaRepository.ExcluiGeneroNovel(generoNovel);
                }
            }

            var arrayGenero = listaGeneros[0]?.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            if (arrayGenero != null && arrayGenero.Length > 0)
            {
                foreach (var genero in arrayGenero)
                {
                    var slugGenero = TratamentoDeStrings.RetornaStringSlug(genero);
                    var generoEncontrado = _context.Generos.AsNoTracking().SingleOrDefault(s => s.Slug == genero);

                    if (generoEncontrado != null)
                    {
                        await _generoDeParaRepository.AdicionaGeneroNovel(new GeneroNovel { NovelId = novel.Id, GeneroId = generoEncontrado.Id });
                    }
                    else
                    {
                        var novoGenero = new Genero();
                        novoGenero.Descricao = genero;
                        novoGenero.Slug = slugGenero;
                        novoGenero.DataInclusao = DateTime.Now;
                        novoGenero.DataAlteracao = novoGenero.DataInclusao;
                        novoGenero.UsuarioInclusao = novel.UsuarioInclusao;

                        await _generoRepository.AdicionaGenero(novoGenero);
                        await _generoDeParaRepository.AdicionaGeneroNovel(new GeneroNovel { NovelId = novel.Id, GeneroId = novoGenero.Id});
                    }

                    await AlteracoesSalvas();
                }
            }
        }

        public async Task InsereGenerosComic(Comic comic, List<string> listaGeneros, bool inclusao)
        {
            if (inclusao)
            {
                comic.GenerosComic = new List<GeneroComic>();
            }
            else
            {
                foreach (var generosComic in comic.GenerosComic)
                {
                    _generoDeParaRepository.ExcluiGeneroComic(generosComic);
                }
            }

            var arrayGenero = listaGeneros[0]?.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            if (arrayGenero != null && arrayGenero.Length > 0)
            {
                foreach (var genero in arrayGenero)
                {
                    var slugGenero = TratamentoDeStrings.RetornaStringSlug(genero);
                    var generoEncontrado = _context.Generos.AsNoTracking().SingleOrDefault(s => s.Slug == genero);

                    if (generoEncontrado != null)
                    {
                        await _generoDeParaRepository.AdicionaGeneroComic(new GeneroComic { ComicId = comic.Id, GeneroId = generoEncontrado.Id });
                    }
                    else
                    {
                        var novoGenero = new Genero();
                        novoGenero.Descricao = genero;
                        novoGenero.Slug = slugGenero;
                        novoGenero.DataInclusao = DateTime.Now;
                        novoGenero.DataAlteracao = novoGenero.DataInclusao;
                        novoGenero.UsuarioInclusao = comic.UsuarioInclusao;

                        await _generoRepository.AdicionaGenero(novoGenero);
                        await _generoDeParaRepository.AdicionaGeneroComic(new GeneroComic { ComicId = comic.Id, GeneroId = generoEncontrado.Id });
                    }

                    await AlteracoesSalvas();
                }
            }
        }


        public async Task<bool> AlteracoesSalvas()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}