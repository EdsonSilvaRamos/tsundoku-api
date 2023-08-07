﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TsundokuTraducoes.Api.Data;

#nullable disable

namespace TsundokuTraducoes.Api.Migrations
{
    [DbContext(typeof(TsundokuContext))]
    partial class TsundokuContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.CapituloComic", b =>
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

                    b.ToTable("CapituloManga");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.CapituloNovel", b =>
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

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.ComentarioObraRecomendada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AutorComentario")
                        .HasColumnType("longtext");

                    b.Property<string>("Comentario")
                        .HasColumnType("longtext");

                    b.Property<int>("ObraRecomendadaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ObraRecomendadaId");

                    b.ToTable("ComentarioObraRecomendada");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Genero", b =>
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

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.GeneroObra", b =>
                {
                    b.Property<int?>("ObraId")
                        .HasColumnType("int");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.HasKey("ObraId", "GeneroId");

                    b.HasIndex("GeneroId");

                    b.ToTable("GeneroObra");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Imagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("IdCapitulo")
                        .HasColumnType("int");

                    b.Property<int?>("IdObra")
                        .HasColumnType("int");

                    b.Property<int?>("IdPost")
                        .HasColumnType("int");

                    b.Property<int?>("IdVolume")
                        .HasColumnType("int");

                    b.Property<string>("UrlImagem")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Imagem");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Obra", b =>
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

                    b.ToTable("Obra");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.ObraRecomendada", b =>
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

                    b.ToTable("ObraRecomendada");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Volume", b =>
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

                    b.ToTable("Volume");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.CapituloComic", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Volume", "Volume")
                        .WithMany("ListaCapituloComic")
                        .HasForeignKey("VolumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Volume");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.CapituloNovel", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Volume", "Volume")
                        .WithMany("ListaCapituloNovel")
                        .HasForeignKey("VolumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Volume");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.ComentarioObraRecomendada", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.ObraRecomendada", "ObraRecomendada")
                        .WithMany("ListaComentarioObraRecomendada")
                        .HasForeignKey("ObraRecomendadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ObraRecomendada");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.GeneroObra", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Genero", "Genero")
                        .WithMany("GenerosObra")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TsundokuTraducoes.Api.Models.Obra", "Obra")
                        .WithMany("GenerosObra")
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");

                    b.Navigation("Obra");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Volume", b =>
                {
                    b.HasOne("TsundokuTraducoes.Api.Models.Obra", "Obra")
                        .WithMany("Volumes")
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Obra");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Genero", b =>
                {
                    b.Navigation("GenerosObra");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Obra", b =>
                {
                    b.Navigation("GenerosObra");

                    b.Navigation("Volumes");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.ObraRecomendada", b =>
                {
                    b.Navigation("ListaComentarioObraRecomendada");
                });

            modelBuilder.Entity("TsundokuTraducoes.Api.Models.Volume", b =>
                {
                    b.Navigation("ListaCapituloComic");

                    b.Navigation("ListaCapituloNovel");
                });
#pragma warning restore 612, 618
        }
    }
}
