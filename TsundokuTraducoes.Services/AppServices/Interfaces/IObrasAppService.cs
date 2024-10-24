﻿using TsundokuTraducoes.Helpers.DTOs.Public.Request;
using TsundokuTraducoes.Helpers.DTOs.Public.Retorno;

namespace TsundokuTraducoes.Services.AppServices.Interfaces
{
    public interface IObrasAppService
    {
        Task<List<RetornoObras>> ObterListaNovels(RequestObras requestObras);
        Task<List<RetornoObras>> ObterListaNovelsRecentes();
        Task<RetornoObras> ObterNovelPorId(RequestObras requestObras);

        Task<List<RetornoObras>> ObterListaComics(RequestObras requestObras);
        Task<List<RetornoObras>> ObterListaComicsRecentes();
        Task<RetornoObras> ObterComicPorId(RequestObras requestObras);

        Task<List<RetornoCapitulosHome>> ObterCapitulosHome();
        Task<List<RetornoObrasRecomendadas>> ObterObrasRecomendadas();
        
        List<RetornoVolumes> ObterListaVolumeCapitulos(RequestObras requestObras);
    }
}