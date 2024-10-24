﻿using TsundokuTraducoes.Integration.Tests.Recursos;

namespace TsundokuTraducoes.Integration.Tests.Capitulos
{
    public static class MockCapituloComic
    {
        public static MultipartFormDataContent RetornaFormDataMockAdicionarCapituloComic(bool falhar, Guid volumeId)
        {
            var form = new MultipartFormDataContent();
            var numero = $"{RetornaNumeroAleatorio()}";

            form.Add(new StringContent(numero), "Numero");
            form.Add(new StringContent(""), "Parte");
            form.Add(new StringContent("O mestre"), "Titulo");
            form.Add(new StringContent("Bravo"), "UsuarioInclusao");
            form.Add(new StringContent(volumeId.ToString()), "VolumeId");
            form.Add(new StringContent("1"), "OrdemCapitulo");
            form.Add(new StringContent("false"), "OtimizarImagem");
            form.Add(new StringContent("true"), "SalvarLocal");
            

            if (!falhar)
            {
                var listaContentImagemCapitulo = new List<HttpContent>();

                for (int i = 0; i < 25; i++)
                {
                    listaContentImagemCapitulo.Add(MockBase.RetornaStreamImagemMock($"pagina{i:00}.jpeg", "ListaImagensForm"));
                }

                foreach (var contentImagemCapitulo in listaContentImagemCapitulo)
                {
                    form.Add(contentImagemCapitulo);
                }
            }

            return form;
        }

        public static MultipartFormDataContent RetornaFormDataMockAtualizarCapituloComic(bool falhar, Guid volumeId, Guid capituloId)
        {
            var form = new MultipartFormDataContent();
            var numero = $"{RetornaNumeroAleatorio()}";
            var loginAlteracao = "Araragui";
            
            if (falhar)
            {
                loginAlteracao =string.Empty;
            }

            form.Add(new StringContent(capituloId.ToString()), "Id");
            form.Add(new StringContent(numero), "Numero");
            form.Add(new StringContent(""), "Parte");
            form.Add(new StringContent("O mestre"), "Titulo");
            form.Add(new StringContent("Bravo"), "UsuarioInclusao");
            form.Add(new StringContent(loginAlteracao), "UsuarioAlteracao");
            form.Add(new StringContent(volumeId.ToString()), "VolumeId");
            form.Add(new StringContent("1"), "OrdemCapitulo");
            form.Add(new StringContent("false"), "OtimizarImagem");
            form.Add(new StringContent("true"), "SalvarLocal");

            var listaContentImagemCapitulo = new List<HttpContent>();

            for (int i = 0; i < 5; i++)
            {
                listaContentImagemCapitulo.Add(MockBase.RetornaStreamImagemMock($"pagina{i:00}.jpeg", "ListaImagensForm"));
            }

            foreach (var contentImagemCapitulo in listaContentImagemCapitulo)
            {
                form.Add(contentImagemCapitulo);
            }

            return form;
        }

        public static MultipartFormDataContent RetornaFormDataMockAdicionaComic()
        {
            var form = new MultipartFormDataContent();
            var titulo = $"Comic Teste Volume - {Guid.NewGuid().ToString().Substring(0, 8)}_{Guid.NewGuid().ToString().Substring(0, 8)}";

            form.Add(new StringContent(titulo), "Titulo");
            form.Add(new StringContent(titulo), "Alias");
            form.Add(new StringContent("A Eminência nas Sombras, The Eminence in Shadow, To Be a Power in The Shadow"), "TituloAlternativo");
            form.Add(new StringContent("Aizawa Daisuke"), "Autor");
            form.Add(new StringContent("SAKANO Anri"), "Artista");
            form.Add(new StringContent("2018"), "Ano");
            form.Add(new StringContent("Bravo"), "UsuarioInclusao");
            form.Add(new StringContent("Da mesma forma que todos já adoraram heróis em sua infância, um certo jovem admirava aqueles que agiam nas sombras."), "Sinopse");
            form.Add(new StringContent("false"), "EhObraMaiorIdade");
            form.Add(new StringContent("fantasia,aventura,drama"), "ListaGeneros");
            form.Add(new StringContent("#81F7F3"), "CodigoCorHexaObra");
            form.Add(new StringContent("japonesa"), "NacionalidadeSlug");
            form.Add(new StringContent("em-andamento"), "StatusObraSlug");
            form.Add(new StringContent("manga"), "TipoObraSlug");
            form.Add(new StringContent("false"), "EhRecomendacao");
            form.Add(new StringContent("false"), "OtimizarImagem");
            form.Add(new StringContent("true"), "SalvarLocal");

            var contentImagemPrincipal = MockBase.RetornaStreamImagemMock("imagemPrincipal.jpeg", "ImagemCapaPrincipalFile");
            var contentImagemBanner = MockBase.RetornaStreamImagemMock("imagemBanner.jpeg", "ImagemBannerFile");
            form.Add(contentImagemPrincipal);
            form.Add(contentImagemBanner);

            return form;
        }

        public static MultipartFormDataContent RetornaFormDataMockAdicionarVolumeComic(Guid obraId)
        {
            var form = new MultipartFormDataContent();
            var numero = $"{RetornaNumeroAleatorio()}";

            form.Add(new StringContent(""), "Titulo");
            form.Add(new StringContent(numero), "Numero");
            form.Add(new StringContent("O mestre"), "Sinopse");
            form.Add(new StringContent("Bravo"), "UsuarioInclusao");
            form.Add(new StringContent(obraId.ToString()), "ObraId");
            var contentImagemVolume = MockBase.RetornaStreamImagemMock("imagemVolume.jpeg", "ImagemVolumeFile");
            form.Add(contentImagemVolume);
            form.Add(new StringContent("false"), "OtimizarImagem");
            form.Add(new StringContent("true"), "SalvarLocal");

            return form;
        }

        private static string RetornaNumeroAleatorio()
        {
            var random = new Random();
            return $"{random.Next(1, 199)}.{random.Next(1, 199)}";
        }
    }
}