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
    [Migration("20230825012341_MigracaoInicial")]
    partial class MigracaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Capitulo.CapituloComic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescritivoCapitulo")
                        .HasColumnType("longtext");

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

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("longtext");

                    b.Property<int>("VolumeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VolumeId");

                    b.ToTable("CapituloComic");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Capitulo.CapituloNovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConteudoNovel")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescritivoCapitulo")
                        .HasColumnType("longtext");

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

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("longtext");

                    b.Property<int>("VolumeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VolumeId");

                    b.ToTable("CapituloNovel");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Genero.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Slug")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Genero");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Ação",
                            Slug = "acao"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Aventura",
                            Slug = "aventura"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Comédia",
                            Slug = "comedia"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Drama",
                            Slug = "drama"
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Slice of Life",
                            Slug = "slice-of-life"
                        },
                        new
                        {
                            Id = 6,
                            Descricao = "Isekai",
                            Slug = "isekai"
                        },
                        new
                        {
                            Id = 7,
                            Descricao = "Harém",
                            Slug = "harem"
                        },
                        new
                        {
                            Id = 8,
                            Descricao = "Horror",
                            Slug = "horror"
                        },
                        new
                        {
                            Id = 9,
                            Descricao = "Fantasia",
                            Slug = "fantasia"
                        },
                        new
                        {
                            Id = 10,
                            Descricao = "Seinen",
                            Slug = "seinen"
                        });
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Genero.GeneroObra", b =>
                {
                    b.Property<int?>("ObraId")
                        .HasColumnType("int");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.Property<int?>("ComicId")
                        .HasColumnType("int");

                    b.HasKey("ObraId", "GeneroId");

                    b.HasIndex("ComicId");

                    b.HasIndex("GeneroId");

                    b.ToTable("GeneroObra");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Obra.Comic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

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

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataAtualizacaoUltimoCapitulo")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DiretorioImagemObra")
                        .HasColumnType("longtext");

                    b.Property<bool>("EhObraMaiorIdade")
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

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("longtext");

                    b.Property<int>("Visualizacoes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Comic");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Obra.Novel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

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

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataAtualizacaoUltimoCapitulo")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DiretorioImagemObra")
                        .HasColumnType("longtext");

                    b.Property<bool>("EhObraMaiorIdade")
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

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("longtext");

                    b.Property<int>("Visualizacoes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Novel");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Recomendacao.Comic.ComentarioComicRecomendada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AutorComentario")
                        .HasColumnType("longtext");

                    b.Property<string>("Comentario")
                        .HasColumnType("longtext");

                    b.Property<int>("ComicRecomendadaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComicRecomendadaId");

                    b.ToTable("ComentarioComicRecomendada");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Recomendacao.Comic.ComicRecomendada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdObra")
                        .HasColumnType("int");

                    b.Property<string>("Sinopse")
                        .HasColumnType("longtext");

                    b.Property<string>("SlugObra")
                        .HasColumnType("longtext");

                    b.Property<string>("TituloAliasObra")
                        .HasColumnType("longtext");

                    b.Property<string>("UrlImagemCapaPrincipal")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ComicRecomendada");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Recomendacao.Novel.ComentarioNovelRecomendada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AutorComentario")
                        .HasColumnType("longtext");

                    b.Property<string>("Comentario")
                        .HasColumnType("longtext");

                    b.Property<int>("NovelRecomendadaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NovelRecomendadaId");

                    b.ToTable("ComentarioNovelRecomendada");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Recomendacao.Novel.NovelRecomendada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdObra")
                        .HasColumnType("int");

                    b.Property<string>("Sinopse")
                        .HasColumnType("longtext");

                    b.Property<string>("SlugObra")
                        .HasColumnType("longtext");

                    b.Property<string>("TituloAliasObra")
                        .HasColumnType("longtext");

                    b.Property<string>("UrlImagemCapaPrincipal")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("NovelRecomendada");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Volume.VolumeComic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescritivoVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("DiretorioImagemVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<int>("ObraId")
                        .HasColumnType("int");

                    b.Property<string>("Sinopse")
                        .HasColumnType("longtext");

                    b.Property<string>("Slug")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ObraId");

                    b.ToTable("VolumeComic");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Volume.VolumeNovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescritivoVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("DiretorioImagemVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("ImagemVolume")
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<int>("ObraId")
                        .HasColumnType("int");

                    b.Property<string>("Sinopse")
                        .HasColumnType("longtext");

                    b.Property<string>("Slug")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext");

                    b.Property<string>("UsuarioCadastro")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ObraId");

                    b.ToTable("VolumeNovel");
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

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Genero.GeneroObra", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Obra.Comic", null)
                        .WithMany("GenerosObra")
                        .HasForeignKey("ComicId");

                    b.HasOne("TsundokuTraducoes.Api.Models.Genero.Genero", "Genero")
                        .WithMany("GenerosObra")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TsundokuTraducoes.Api.Models.Obra.Novel", "Obra")
                        .WithMany("GenerosObra")
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");

                    b.Navigation("Obra");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Recomendacao.Comic.ComentarioComicRecomendada", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Recomendacao.Comic.ComicRecomendada", "ComicRecomendada")
                        .WithMany("ListaComentarioComicRecomendada")
                        .HasForeignKey("ComicRecomendadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ComicRecomendada");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Recomendacao.Novel.ComentarioNovelRecomendada", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Recomendacao.Novel.NovelRecomendada", "NovelRecomendada")
                        .WithMany("ListaComentarioObraRecomendada")
                        .HasForeignKey("NovelRecomendadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NovelRecomendada");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Volume.VolumeComic", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Obra.Comic", "Obra")
                        .WithMany("Volumes")
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Obra");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Volume.VolumeNovel", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Obra.Novel", "Obra")
                        .WithMany("Volumes")
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Obra");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Genero.Genero", b =>
                {
                    b.Navigation("GenerosObra");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Obra.Comic", b =>
                {
                    b.Navigation("GenerosObra");

                    b.Navigation("Volumes");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Obra.Novel", b =>
                {
                    b.Navigation("GenerosObra");

                    b.Navigation("Volumes");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Recomendacao.Comic.ComicRecomendada", b =>
                {
                    b.Navigation("ListaComentarioComicRecomendada");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Recomendacao.Novel.NovelRecomendada", b =>
                {
                    b.Navigation("ListaComentarioObraRecomendada");
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