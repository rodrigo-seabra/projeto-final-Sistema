﻿// <auto-generated />
using System;
using LookingThings.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LookingThings.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240618114622_AddObservacaoLocalToObservacoes")]
    partial class AddObservacaoLocalToObservacoes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LookingThings.Models.Objeto", b =>
                {
                    b.Property<int>("ObjetoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ObjetoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObjetoId"));

                    b.Property<string>("ObjetoCor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoCor");

                    b.Property<DateTime>("ObjetoDtDesaparecimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("ObjetoDtDesaparecimento");

                    b.Property<DateTime?>("ObjetoDtEncontro")
                        .HasColumnType("datetime2")
                        .HasColumnName("ObjetoDtEncontro");

                    b.Property<string>("ObjetoFoto")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoFoto");

                    b.Property<string>("ObjetoLocalDesaparecimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoLocalDesaparecimento");

                    b.Property<string>("ObjetoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoNome");

                    b.Property<string>("ObjetoObservacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObjetoObservacao");

                    b.Property<byte>("ObjetoStatus")
                        .HasColumnType("tinyint")
                        .HasColumnName("ObjetoStatus");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ObjetoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Objeto");
                });

            modelBuilder.Entity("LookingThings.Models.Observacoes", b =>
                {
                    b.Property<int>("ObservacoesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ObservacoesId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObservacoesId"));

                    b.Property<int>("ObjetoId")
                        .HasColumnType("int");

                    b.Property<string>("ObservacaoLocal")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacaoLocal");

                    b.Property<DateTime?>("ObservacoesData")
                        .HasColumnType("datetime2")
                        .HasColumnName("ObservacoesData");

                    b.Property<string>("ObservacoesDescricao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacoesDescricao");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ObservacoesId");

                    b.HasIndex("ObjetoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Observacoes");
                });

            modelBuilder.Entity("LookingThings.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("UsuarioEmail")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEmail");

                    b.Property<string>("UsuarioNome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioNome");

                    b.Property<string>("UsuarioSenha")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioSenha");

                    b.Property<string>("UsuarioTelefone")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioTelefone");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("LookingThings.Models.Objeto", b =>
                {
                    b.HasOne("LookingThings.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("LookingThings.Models.Observacoes", b =>
                {
                    b.HasOne("LookingThings.Models.Objeto", "Objeto")
                        .WithMany()
                        .HasForeignKey("ObjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LookingThings.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Objeto");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
