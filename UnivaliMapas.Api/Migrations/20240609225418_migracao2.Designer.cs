﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UnivaliMapas.Api.DbContexts;

#nullable disable

namespace UnivaliMapas.Migrations
{
    [DbContext(typeof(UnivaliContext))]
    [Migration("20240609225418_migracao2")]
    partial class migracao2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UnivaliMapas.Api.Entities.AlunoMateria", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("MateriaId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "MateriaId");

                    b.HasIndex("MateriaId");

                    b.ToTable("AlunoMateria", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            MateriaId = 1
                        },
                        new
                        {
                            UserId = 2,
                            MateriaId = 1
                        });
                });

            modelBuilder.Entity("UnivaliMapas.Api.Entities.Aula", b =>
                {
                    b.Property<int>("AulaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AulaId"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MateriaId")
                        .HasColumnType("integer");

                    b.Property<int>("SalaId")
                        .HasColumnType("integer");

                    b.HasKey("AulaId");

                    b.HasIndex("MateriaId");

                    b.HasIndex("SalaId");

                    b.ToTable("Aulas");

                    b.HasData(
                        new
                        {
                            AulaId = 1,
                            Data = new DateTime(2024, 6, 9, 22, 54, 18, 130, DateTimeKind.Utc).AddTicks(9590),
                            MateriaId = 1,
                            SalaId = 1
                        },
                        new
                        {
                            AulaId = 2,
                            Data = new DateTime(2024, 6, 10, 22, 54, 18, 130, DateTimeKind.Utc).AddTicks(9592),
                            MateriaId = 2,
                            SalaId = 5
                        },
                        new
                        {
                            AulaId = 3,
                            Data = new DateTime(2024, 6, 11, 22, 54, 18, 130, DateTimeKind.Utc).AddTicks(9600),
                            MateriaId = 1,
                            SalaId = 3
                        });
                });

            modelBuilder.Entity("UnivaliMapas.Api.Entities.Bloco", b =>
                {
                    b.Property<int>("BlocoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BlocoID"));

                    b.Property<char>("LetraBloco")
                        .HasColumnType("character(1)");

                    b.HasKey("BlocoID");

                    b.ToTable("Blocos");

                    b.HasData(
                        new
                        {
                            BlocoID = 1,
                            LetraBloco = 'A'
                        },
                        new
                        {
                            BlocoID = 2,
                            LetraBloco = 'B'
                        },
                        new
                        {
                            BlocoID = 3,
                            LetraBloco = 'C'
                        });
                });

            modelBuilder.Entity("UnivaliMapas.Api.Entities.Materia", b =>
                {
                    b.Property<int>("MateriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MateriaId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("integer");

                    b.HasKey("MateriaId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Materias");

                    b.HasData(
                        new
                        {
                            MateriaId = 1,
                            Name = "Engenharia de Software",
                            ProfessorId = 3
                        },
                        new
                        {
                            MateriaId = 2,
                            Name = "Sistemas Operacionais",
                            ProfessorId = 3
                        });
                });

            modelBuilder.Entity("UnivaliMapas.Api.Entities.Sala", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SalaId"));

                    b.Property<int>("BlocoId")
                        .HasColumnType("integer");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.HasKey("SalaId");

                    b.HasIndex("BlocoId");

                    b.ToTable("Salas");

                    b.HasData(
                        new
                        {
                            SalaId = 1,
                            BlocoId = 1,
                            Number = 101
                        },
                        new
                        {
                            SalaId = 2,
                            BlocoId = 1,
                            Number = 102
                        },
                        new
                        {
                            SalaId = 3,
                            BlocoId = 2,
                            Number = 103
                        },
                        new
                        {
                            SalaId = 4,
                            BlocoId = 2,
                            Number = 104
                        },
                        new
                        {
                            SalaId = 5,
                            BlocoId = 3,
                            Number = 105
                        },
                        new
                        {
                            SalaId = 6,
                            BlocoId = 3,
                            Number = 106
                        });
                });

            modelBuilder.Entity("UnivaliMapas.Api.Entities.Usuario", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("CodigoPessoa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("UserId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CodigoPessoa = "11111111",
                            Cpf = "000.000.000-00",
                            Name = "Vinicius Setti",
                            Password = "5phLUbbFkT1Kzcr0uGJgdCRUjWtXPqvQPIGjNkv17w0=",
                            Role = 0
                        },
                        new
                        {
                            UserId = 2,
                            CodigoPessoa = "22222222",
                            Cpf = "000.000.000-00",
                            Name = "Alisson Pokrywiecki",
                            Password = "5phLUbbFkT1Kzcr0uGJgdCRUjWtXPqvQPIGjNkv17w0=",
                            Role = 0
                        },
                        new
                        {
                            UserId = 3,
                            CodigoPessoa = "33333333",
                            Cpf = "000.000.000-00",
                            Name = "Thiago Felski",
                            Password = "5phLUbbFkT1Kzcr0uGJgdCRUjWtXPqvQPIGjNkv17w0=",
                            Role = 1
                        });
                });

            modelBuilder.Entity("UnivaliMapas.Api.Entities.AlunoMateria", b =>
                {
                    b.HasOne("UnivaliMapas.Api.Entities.Materia", null)
                        .WithMany("AlunoMaterias")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UnivaliMapas.Api.Entities.Usuario", null)
                        .WithMany("AlunoMaterias")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UnivaliMapas.Api.Entities.Aula", b =>
                {
                    b.HasOne("UnivaliMapas.Api.Entities.Materia", "Materia")
                        .WithMany("Aulas")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UnivaliMapas.Api.Entities.Sala", "Sala")
                        .WithMany("Aulas")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materia");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("UnivaliMapas.Api.Entities.Materia", b =>
                {
                    b.HasOne("UnivaliMapas.Api.Entities.Usuario", "Professor")
                        .WithMany("MateriasMinistradas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("UnivaliMapas.Api.Entities.Sala", b =>
                {
                    b.HasOne("UnivaliMapas.Api.Entities.Bloco", "Bloco")
                        .WithMany("Salas")
                        .HasForeignKey("BlocoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bloco");
                });

            modelBuilder.Entity("UnivaliMapas.Api.Entities.Bloco", b =>
                {
                    b.Navigation("Salas");
                });

            modelBuilder.Entity("UnivaliMapas.Api.Entities.Materia", b =>
                {
                    b.Navigation("AlunoMaterias");

                    b.Navigation("Aulas");
                });

            modelBuilder.Entity("UnivaliMapas.Api.Entities.Sala", b =>
                {
                    b.Navigation("Aulas");
                });

            modelBuilder.Entity("UnivaliMapas.Api.Entities.Usuario", b =>
                {
                    b.Navigation("AlunoMaterias");

                    b.Navigation("MateriasMinistradas");
                });
#pragma warning restore 612, 618
        }
    }
}
