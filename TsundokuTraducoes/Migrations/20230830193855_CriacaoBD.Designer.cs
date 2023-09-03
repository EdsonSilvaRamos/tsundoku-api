﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TsundokuTraducoes.Api.Data;

#nullable disable

namespace TsundokuTraducoes.Api.Migrations
{
    [DbContext(typeof(TsundokuContext))]
    [Migration("20230830193855_CriacaoBD")]
    partial class CriacaoBD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Capitulo.CapituloComic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DiretorioImagemCapitulo")
                        .HasColumnType("longtext");

                    b.Property<string>("ListaImagens")
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<int>("OrdemCapitulo")
                        .HasColumnType("int");

                    b.Property<string>("Parte")
                        .HasColumnType("longtext");

                    b.Property<string>("Slug")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioInclusao")
                        .HasColumnType("longtext");

                    b.Property<Guid>("VolumeId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("VolumeId");

                    b.ToTable("CapitulosComic");

                    b.HasData(
                        new
                        {
                            Id = new Guid("08dba6c0-f903-469b-866c-223f5ab45e56"),
                            DataAlteracao = new DateTime(2023, 8, 30, 16, 38, 54, 900, DateTimeKind.Local).AddTicks(2495),
                            DataInclusao = new DateTime(2023, 8, 30, 16, 38, 54, 900, DateTimeKind.Local).AddTicks(2494),
                            DiretorioImagemCapitulo = "C:\\Users\\edsra\\source\\repos\\tsundoku-api\\TsundokuTraducoes\\wwwroot\\assets\\images\\HatsukoiLosstime\\Volume01\\Capitulo01",
                            ListaImagens = "[{\\\"Id\\\": 1,\\\"Ordem\\\": 1,\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2022/01/0-46.jpg\\\"},{\\\"Id\\\": 2,\\\"Ordem\\\": 2,\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2022/01/0-47.jpg\\\"},{\\\"Id\\\": 3,\\\"Ordem\\\": 3,\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2022/01/1-60.jpg\\\"},{\\\"Id\\\": 4,\\\"Ordem\\\": 4,\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2022/01/2-60.jpg\\\"},{\\\"Id\\\": 5,\\\"Ordem\\\": 5,\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2022/01/3-61.jpg\\\"},{\\\"Id\\\": 6,\\\"Ordem\\\": 6,\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2022/01/4-61.jpg\\\"},{\\\"Id\\\": 7,\\\"Ordem\\\": 7,\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2022/01/5-61.jpg\\\"},{\\\"Id\\\": 8,\\\"Ordem\\\": 8,\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2022/01/6-61.jpg\\\"},{\\\"Id\\\": 9,\\\"Ordem\\\": 9,\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2022/01/7-61.jpg\\\"},{\\\"Id\\\": 10,\\\"Ordem\\\": 10,\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2022/01/8-61.jpg\\\"},{\\\"Id\\\": 10,\\\"Ordem\\\": 10,\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2022/01/9-61.jpg\\\"},{\\\"Id\\\": 10,\\\"Ordem\\\": 10,\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2022/01/10-108.jpg\\\"}]",
                            Numero = "1",
                            OrdemCapitulo = 1,
                            Slug = "capitulo-1",
                            UsuarioInclusao = "Bravo",
                            VolumeId = new Guid("08dba651-ec33-4964-8f67-eecd4cbaea50")
                        });
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Capitulo.CapituloNovel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConteudoNovel")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DiretorioImagemCapitulo")
                        .HasColumnType("longtext");

                    b.Property<bool>("EhIlustracoesNovel")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<int>("OrdemCapitulo")
                        .HasColumnType("int");

                    b.Property<string>("Parte")
                        .HasColumnType("longtext");

                    b.Property<string>("QC")
                        .HasColumnType("longtext");

                    b.Property<string>("Revisor")
                        .HasColumnType("longtext");

                    b.Property<string>("Slug")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.Property<string>("Tradutor")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioInclusao")
                        .HasColumnType("longtext");

                    b.Property<Guid>("VolumeId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("VolumeId");

                    b.ToTable("CapitulosNovel");

                    b.HasData(
                        new
                        {
                            Id = new Guid("08dba6b4-3619-4cc6-8857-0bbe53a6f670"),
                            ConteudoNovel = "[{\\\"Id\\\": 1,\\\"Ordem\\\": 1,\\\"Alt\\\" = \\\"Tsundoku-Traducoes-Majo-no-Tabitabi-Capa-Volume-01\\\",\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2021/01/Tsundoku-Traducoes-Majo-no-Tabitabi-Capa-Volume-01.jpg\\\"},{\\\"Id\\\": 2,\\\"Ordem\\\": 2,\\\"Alt\\\" = \\\"MJ_V1_ilust_01\\\",\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2021/12/MJ_V1_ilust_01.jpg\\\"},{\\\"Id\\\": 3,\\\"Ordem\\\": 3,\\\"Alt\\\" = \\\"MJ_V1_ilust_02\\\",\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2021/12/MJ_V1_ilust_02.jpg\\\"},{\\\"Id\\\": 4,\\\"Ordem\\\": 4,\\\"Alt\\\" = \\\"MJ_V1_ilust_03\\\",\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2021/12/MJ_V1_ilust_03.jpg\\\"},{\\\"Id\\\": 5,\\\"Ordem\\\": 5,\\\"Alt\\\" = \\\"MJ_V1_ilust_04\\\",\\\"Url\\\": \\\"http://tsundoku.com.br/wp-content/uploads/2021/12/MJ_V1_ilust_04.jpg\\\"}]",
                            DataAlteracao = new DateTime(2023, 8, 30, 16, 38, 54, 900, DateTimeKind.Local).AddTicks(1833),
                            DataInclusao = new DateTime(2023, 8, 30, 16, 38, 54, 900, DateTimeKind.Local).AddTicks(1832),
                            DiretorioImagemCapitulo = "C:\\Users\\edsra\\source\\repos\\tsundoku-api\\TsundokuTraducoes\\wwwroot\\assets\\images\\BruxaErrante\\Volume01\\Ilustracoes",
                            EhIlustracoesNovel = true,
                            Numero = "Ilustrações",
                            OrdemCapitulo = 1,
                            Slug = "ilustracoes",
                            UsuarioInclusao = "Bravo",
                            VolumeId = new Guid("08dba651-c8ee-460a-8b4a-56573c446d2a")
                        },
                        new
                        {
                            Id = new Guid("08dba6bb-8faf-4ce3-85d7-7cfe5b59648b"),
                            ConteudoNovel = "\r\n            <p>Era um país tranquilo, cercado por montanhas proibidas e escondido atrás de muros altos. Ninguém do mundo exterior poderia visitar.</p>\r\n            <p>Acima de uma face rochosa brilhando com o calor da luz do sol, uma única vassoura voava pelo ar quente. A pessoa que a pilotava era uma linda jovem. Ela usava um robe preto e um chapéu pontudo, e seus cabelos cinzentos voavam ao vento. Se alguém estivesse por perto, viraria-se para olhar, imaginando com um suspiro quem seria aquela beldade a voar...</p>\r\n            <p>Isso aí. Eu mesma.</p>\r\n            <p>Ah, era uma piada.</p>\r\n            <p>— Quase lá...</p>\r\n            <p>O muro alto parecia ter sido esculpido na própria montanha. Olhando um pouco para baixo, vi o portão e guiei minha vassoura na direção dele.</p>\r\n            <p>Com certeza foi trabalhoso, mas suponho que as pessoas que moravam aqui o haviam planejado dessa maneira – para impedir que as pessoas entrassem por engano. Afinal, não há como alguém caminhar por um lugar desses sem uma boa razão.</p>\r\n            <p>Desci da minha vassoura bem em frente ao portão. Um sentinela local, aparentemente conduzindo inspeções de imigração, aproximou-se de mim.</p>\r\n            <p>Depois de me olhar lentamente da cabeça aos pés e examinar o broche no meu peito, sorriu alegremente.</p>\r\n            <p>— Bem-vinda ao País dos Magos. Por aqui, Madame Bruxa.</p>\r\n            <p>— Hmm? Você não precisa testar se posso fazer magia ou não?</p>\r\n            <p>Ouvi dizer que quem visitava este país tinha que provar sua capacidade mágica antes de entrar; qualquer pessoa que não alcançasse um determinado nível teria seu acesso negado.</p>\r\n            <p>— Eu a vi voando. E, além disso, esse broche que está usando indica que é uma bruxa. Então, por favor, continue em frente.</p>\r\n            <p><em>Ah sim, é mesmo. Ser capaz de voar em uma vassoura é um dos pré-requisitos mínimos para a entrada. É claro que puderam ver minha aproximação lá da guarita. Que boba que fui!</em></p>\r\n            <p>Depois de me inclinar um pouco para o guarda, passei pelo portão enorme. Aqui estava o País dos Magos. Usuários iniciantes de magia, aprendizes e bruxas de pleno direito – desde que pudessem usar magia, estariam autorizados a entrar neste país curioso, enquanto todos os outros seriam impedidos.</p>\r\n            <p>Ao passar pelo imenso portão, duas placas estranhas, lado a lado, chamaram minha atenção. Olhei para elas um pouco confusa.</p>\r\n            <p>A primeira mostrava um mago montado em uma vassoura, com um círculo ao seu redor. Aquela ao lado mostrava a imagem de um soldado andando, com um triângulo em sua volta.</p>\r\n            <p><em>O que há com essas placas?</em></p>\r\n            <p>Eu soube a resposta assim que olhei para cima – acima do monte de casas de tijolos e sob o sol cintilante, magos de todos os tipos atravessavam o céu em todas as direções.</p>\r\n            <p><em>Entendo. Deve ser uma regra nos países em que permitem apenas a entrada de magos – quase todo mundo está voando em uma vassoura, por isso poucas pessoas escolhem andar.</em></p>\r\n            <p>Satisfeita com minha explicação para as placas, peguei minha vassoura e me sentei de lado. Com um impulso, levantei suavemente no ar em uma demonstração viva do desenho da placa.</p>\r\n            ",
                            DataAlteracao = new DateTime(2023, 8, 30, 16, 38, 54, 900, DateTimeKind.Local).AddTicks(2456),
                            DataInclusao = new DateTime(2023, 8, 30, 16, 38, 54, 900, DateTimeKind.Local).AddTicks(2455),
                            EhIlustracoesNovel = true,
                            Numero = "1",
                            OrdemCapitulo = 2,
                            Slug = "capitulo-1-pais-dos-magos",
                            UsuarioInclusao = "Bravo",
                            VolumeId = new Guid("08dba651-c8ee-460a-8b4a-56573c446d2a")
                        });
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.DePara.GeneroComic", b =>
                {
                    b.Property<Guid>("ComicId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("GeneroId")
                        .HasColumnType("char(36)");

                    b.HasKey("ComicId", "GeneroId");

                    b.HasIndex("GeneroId");

                    b.ToTable("GenerosComic");

                    b.HasData(
                        new
                        {
                            ComicId = new Guid("3d6a759d-8c9e-4891-9f0e-89b8d99821cb"),
                            GeneroId = new Guid("64329027-9111-418c-a6ff-842689916083")
                        });
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.DePara.GeneroNovel", b =>
                {
                    b.Property<Guid>("NovelId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("GeneroId")
                        .HasColumnType("char(36)");

                    b.HasKey("NovelId", "GeneroId");

                    b.HasIndex("GeneroId");

                    b.ToTable("GenerosNovel");

                    b.HasData(
                        new
                        {
                            NovelId = new Guid("97722a6d-2210-434b-ae48-1a3c6da4c7a8"),
                            GeneroId = new Guid("707d2ef9-7fb7-451b-b3fc-be668664a7b0")
                        });
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Generos.Genero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Slug")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Generos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("707d2ef9-7fb7-451b-b3fc-be668664a7b0"),
                            Descricao = "Aventura",
                            Slug = "aventura"
                        },
                        new
                        {
                            Id = new Guid("64329027-9111-418c-a6ff-842689916083"),
                            Descricao = "Seinen",
                            Slug = "seinen"
                        },
                        new
                        {
                            Id = new Guid("47aab5c7-ca3f-4498-9ea4-0fc876ba5057"),
                            Descricao = "Ação",
                            Slug = "acao"
                        },
                        new
                        {
                            Id = new Guid("f063d184-91cb-4900-9c2c-688ceaac6eb0"),
                            Descricao = "Comédia",
                            Slug = "comedia"
                        },
                        new
                        {
                            Id = new Guid("acedd822-00fc-4d22-a1cf-9cf2111b78d9"),
                            Descricao = "Drama",
                            Slug = "drama"
                        },
                        new
                        {
                            Id = new Guid("f1b50f58-e27f-4802-9b7c-d02592218d19"),
                            Descricao = "Slice of Life",
                            Slug = "slice-of-life"
                        },
                        new
                        {
                            Id = new Guid("63785531-7128-425b-9943-08abf1737161"),
                            Descricao = "Isekai",
                            Slug = "isekai"
                        },
                        new
                        {
                            Id = new Guid("26bbd17d-588b-408e-b6ea-80001d1626a3"),
                            Descricao = "Harém",
                            Slug = "harem"
                        },
                        new
                        {
                            Id = new Guid("35bf70fe-adc0-406b-a57b-cd10e754589c"),
                            Descricao = "Horror",
                            Slug = "horror"
                        },
                        new
                        {
                            Id = new Guid("db6059d6-1da0-4cb1-91b1-906d2b9a2c7d"),
                            Descricao = "Fantasia",
                            Slug = "fantasia"
                        });
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Obra.Comic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Alias")
                        .HasColumnType("longtext");

                    b.Property<string>("Ano")
                        .HasColumnType("longtext");

                    b.Property<string>("Artista")
                        .HasColumnType("longtext");

                    b.Property<string>("Autor")
                        .HasColumnType("longtext");

                    b.Property<string>("CargoObraDiscord")
                        .HasColumnType("longtext");

                    b.Property<string>("CodigoCorHexaObra")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataAtualizacaoUltimoCapitulo")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DiretorioImagemObra")
                        .HasColumnType("longtext");

                    b.Property<bool>("EhObraMaiorIdade")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("EhRecomendacao")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImagemBanner")
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemCapaPrincipal")
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemCapaUltimoVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("NacionalidadeSlug")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroUltimoCapitulo")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroUltimoVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("Sinopse")
                        .HasColumnType("longtext");

                    b.Property<string>("Slug")
                        .HasColumnType("longtext");

                    b.Property<string>("SlugUltimoCapitulo")
                        .HasColumnType("longtext");

                    b.Property<string>("SlugUltimoVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("StatusObraSlug")
                        .HasColumnType("longtext");

                    b.Property<string>("TipoObraSlug")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.Property<string>("TituloAlternativo")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioInclusao")
                        .HasColumnType("longtext");

                    b.Property<int>("Visualizacoes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Comics");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3d6a759d-8c9e-4891-9f0e-89b8d99821cb"),
                            Alias = "Hatsukoi Losstime",
                            Ano = "2019",
                            Artista = "Nanora & Zerokich",
                            Autor = "Nishina Yuuki",
                            CargoObraDiscord = "@Hatsukoi Losstime",
                            CodigoCorHexaObra = "#01DFD7",
                            DataAlteracao = new DateTime(2023, 8, 30, 16, 38, 54, 900, DateTimeKind.Local).AddTicks(47),
                            DataInclusao = new DateTime(2023, 8, 30, 16, 38, 54, 900, DateTimeKind.Local).AddTicks(46),
                            DiretorioImagemObra = "C:\\Users\\edsra\\source\\repos\\tsundoku-api\\TsundokuTraducoes\\wwwroot\\assets\\images\\HatsukoiLosstime",
                            EhObraMaiorIdade = false,
                            EhRecomendacao = false,
                            ImagemBanner = "https://tsundoku.com.br/wp-content/uploads/2022/01/HatsukoiEmbed.jpg",
                            ImagemCapaPrincipal = "https://tsundoku.com.br/wp-content/uploads/2022/01/cover_hatsukoi_vol2.jpg",
                            ImagemCapaUltimoVolume = "",
                            NacionalidadeSlug = "japonesa",
                            NumeroUltimoCapitulo = "",
                            NumeroUltimoVolume = "",
                            Sinopse = "Em um mundo onde apenas duas pessoas se moviam...",
                            Slug = "hatsukoi-losstime",
                            SlugUltimoCapitulo = "",
                            SlugUltimoVolume = "",
                            StatusObraSlug = "em-andamento",
                            TipoObraSlug = "comic",
                            Titulo = "Hatsukoi Losstime",
                            TituloAlternativo = "初恋ロスタイム",
                            UsuarioAlteracao = "",
                            UsuarioInclusao = "Bravo",
                            Visualizacoes = 0
                        });
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Obra.Novel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Alias")
                        .HasColumnType("longtext");

                    b.Property<string>("Ano")
                        .HasColumnType("longtext");

                    b.Property<string>("Artista")
                        .HasColumnType("longtext");

                    b.Property<string>("Autor")
                        .HasColumnType("longtext");

                    b.Property<string>("CargoObraDiscord")
                        .HasColumnType("longtext");

                    b.Property<string>("CodigoCorHexaObra")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataAtualizacaoUltimoCapitulo")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DiretorioImagemObra")
                        .HasColumnType("longtext");

                    b.Property<bool>("EhObraMaiorIdade")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("EhRecomendacao")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImagemBanner")
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemCapaPrincipal")
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemCapaUltimoVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("NacionalidadeSlug")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroUltimoCapitulo")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroUltimoVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("Sinopse")
                        .HasColumnType("longtext");

                    b.Property<string>("Slug")
                        .HasColumnType("longtext");

                    b.Property<string>("SlugUltimoCapitulo")
                        .HasColumnType("longtext");

                    b.Property<string>("SlugUltimoVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("StatusObraSlug")
                        .HasColumnType("longtext");

                    b.Property<string>("TipoObraSlug")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.Property<string>("TituloAlternativo")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioInclusao")
                        .HasColumnType("longtext");

                    b.Property<int>("Visualizacoes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Novels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("97722a6d-2210-434b-ae48-1a3c6da4c7a8"),
                            Alias = "Bruxa Errante",
                            Ano = "2017",
                            Artista = "Azure",
                            Autor = "Shiraishi Jougi",
                            CargoObraDiscord = "@Bruxa Errante, a Jornada de Elaina",
                            CodigoCorHexaObra = "#81F7F3",
                            DataAlteracao = new DateTime(2023, 8, 30, 16, 38, 54, 899, DateTimeKind.Local).AddTicks(8607),
                            DataInclusao = new DateTime(2023, 8, 30, 16, 38, 54, 899, DateTimeKind.Local).AddTicks(8606),
                            DiretorioImagemObra = "C:\\Users\\edsra\\source\\repos\\tsundoku-api\\TsundokuTraducoes\\wwwroot\\assets\\images\\BruxaErrante",
                            EhObraMaiorIdade = false,
                            EhRecomendacao = false,
                            ImagemBanner = "https://tsundoku.com.br/wp-content/uploads/2021/12/testeBanner.jpg",
                            ImagemCapaPrincipal = "https://tsundoku.com.br/wp-content/uploads/2021/12/MJ_V8_Capa.jpg",
                            ImagemCapaUltimoVolume = "",
                            NacionalidadeSlug = "japonesa",
                            NumeroUltimoCapitulo = "",
                            NumeroUltimoVolume = "",
                            Sinopse = "A Bruxa, Sim, eu.",
                            Slug = "bruxa-errante-a-jornada-de-elaina",
                            SlugUltimoCapitulo = "",
                            SlugUltimoVolume = "",
                            StatusObraSlug = "em-andamento",
                            TipoObraSlug = "light-novel",
                            Titulo = "Bruxa Errante, a Jornada de Elaina",
                            TituloAlternativo = "Majo no Tabitabi, The Journey of Elaina, The Witch's Travels, 魔女の旅々",
                            UsuarioAlteracao = "",
                            UsuarioInclusao = "Bravo",
                            Visualizacoes = 0
                        });
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Volume.VolumeComic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ComicId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DiretorioImagemVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<string>("Sinopse")
                        .HasColumnType("longtext");

                    b.Property<string>("Slug")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioInclusao")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ComicId");

                    b.ToTable("VolumesComic");

                    b.HasData(
                        new
                        {
                            Id = new Guid("08dba651-ec33-4964-8f67-eecd4cbaea50"),
                            ComicId = new Guid("3d6a759d-8c9e-4891-9f0e-89b8d99821cb"),
                            DataAlteracao = new DateTime(2023, 8, 30, 16, 38, 54, 900, DateTimeKind.Local).AddTicks(1237),
                            DataInclusao = new DateTime(2023, 8, 30, 16, 38, 54, 900, DateTimeKind.Local).AddTicks(1236),
                            DiretorioImagemVolume = "C:\\Users\\edsra\\source\\repos\\tsundoku-api\\TsundokuTraducoes\\wwwroot\\assets\\images\\HatsukoiLosstime\\Volume01",
                            ImagemVolume = "https://tsundoku.com.br/wp-content/uploads/2022/01/Hatsukoi_cover.jpg",
                            Numero = "1",
                            Sinopse = "",
                            Slug = "volume-1",
                            Titulo = "",
                            UsuarioInclusao = "Bravo"
                        });
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Volume.VolumeNovel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DiretorioImagemVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemVolume")
                        .HasColumnType("longtext");

                    b.Property<Guid>("NovelId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<string>("Sinopse")
                        .HasColumnType("longtext");

                    b.Property<string>("Slug")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioInclusao")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("NovelId");

                    b.ToTable("VolumesNovel");

                    b.HasData(
                        new
                        {
                            Id = new Guid("08dba651-c8ee-460a-8b4a-56573c446d2a"),
                            DataAlteracao = new DateTime(2023, 8, 30, 16, 38, 54, 900, DateTimeKind.Local).AddTicks(644),
                            DataInclusao = new DateTime(2023, 8, 30, 16, 38, 54, 900, DateTimeKind.Local).AddTicks(643),
                            DiretorioImagemVolume = "C:\\Users\\edsra\\source\\repos\\tsundoku-api\\TsundokuTraducoes\\wwwroot\\assets\\images\\BruxaErrante\\Volume01",
                            ImagemVolume = "https://tsundoku.com.br/wp-content/uploads/2021/01/Tsundoku-Traducoes-Majo-no-Tabitabi-Capa-Volume-01.jpg",
                            NovelId = new Guid("97722a6d-2210-434b-ae48-1a3c6da4c7a8"),
                            Numero = "1",
                            Sinopse = "",
                            Slug = "volume-1",
                            Titulo = "",
                            UsuarioInclusao = "Bravo"
                        });
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Capitulo.CapituloComic", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Volume.VolumeComic", "Volume")
                        .WithMany("ListaCapitulo")
                        .HasForeignKey("VolumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Volume");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Capitulo.CapituloNovel", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Volume.VolumeNovel", "Volume")
                        .WithMany("ListaCapitulo")
                        .HasForeignKey("VolumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Volume");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.DePara.GeneroComic", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Obra.Comic", "Comic")
                        .WithMany("GenerosComic")
                        .HasForeignKey("ComicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TsundokuTraducoes.Api.Models.Generos.Genero", "Genero")
                        .WithMany("GenerosComic")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comic");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.DePara.GeneroNovel", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Generos.Genero", "Genero")
                        .WithMany("GenerosNovel")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TsundokuTraducoes.Api.Models.Obra.Novel", "Novel")
                        .WithMany("GenerosNovel")
                        .HasForeignKey("NovelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");

                    b.Navigation("Novel");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Volume.VolumeComic", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Obra.Comic", "Comic")
                        .WithMany("Volumes")
                        .HasForeignKey("ComicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comic");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Volume.VolumeNovel", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Obra.Novel", "Novel")
                        .WithMany("Volumes")
                        .HasForeignKey("NovelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Novel");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Generos.Genero", b =>
                {
                    b.Navigation("GenerosComic");

                    b.Navigation("GenerosNovel");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Obra.Comic", b =>
                {
                    b.Navigation("GenerosComic");

                    b.Navigation("Volumes");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Obra.Novel", b =>
                {
                    b.Navigation("GenerosNovel");

                    b.Navigation("Volumes");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Volume.VolumeComic", b =>
                {
                    b.Navigation("ListaCapitulo");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Volume.VolumeNovel", b =>
                {
                    b.Navigation("ListaCapitulo");
                });
#pragma warning restore 612, 618
        }
    }
}