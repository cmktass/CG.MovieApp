﻿// <auto-generated />
using System;
using CG.MovieApp.DataAccess.Concrate.EntityFrameworkCore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CG.MovieApp.DataAccess.Migrations
{
    [DbContext(typeof(MovieAppContext))]
    [Migration("20201223215946_FirstMigrations")]
    partial class FirstMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CG.MovieAppEntity.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("CG.MovieAppEntity.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CG.MovieAppEntity.Entities.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("CG.MovieAppEntity.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Budget")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<int>("DirectorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FragmentUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("ImdbScore")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("NameTr")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Revenues")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Time")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("VisionDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("CG.MovieAppEntity.Entities.FilmActor", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FilmId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ActorId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("FilmActors");
                });

            modelBuilder.Entity("CG.MovieAppEntity.Entities.FilmCategory", b =>
                {
                    b.Property<int>("FilmId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FilmId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("FilmCategories");
                });

            modelBuilder.Entity("CG.MovieAppEntity.Entities.Film", b =>
                {
                    b.HasOne("CG.MovieAppEntity.Entities.Director", "Director")
                        .WithMany("Films")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");
                });

            modelBuilder.Entity("CG.MovieAppEntity.Entities.FilmActor", b =>
                {
                    b.HasOne("CG.MovieAppEntity.Entities.Actor", "Actor")
                        .WithMany("FilmActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CG.MovieAppEntity.Entities.Film", "Film")
                        .WithMany("FilmActors")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("CG.MovieAppEntity.Entities.FilmCategory", b =>
                {
                    b.HasOne("CG.MovieAppEntity.Entities.Category", "Category")
                        .WithMany("FilmCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CG.MovieAppEntity.Entities.Film", "Film")
                        .WithMany("FilmCategories")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("CG.MovieAppEntity.Entities.Actor", b =>
                {
                    b.Navigation("FilmActors");
                });

            modelBuilder.Entity("CG.MovieAppEntity.Entities.Category", b =>
                {
                    b.Navigation("FilmCategories");
                });

            modelBuilder.Entity("CG.MovieAppEntity.Entities.Director", b =>
                {
                    b.Navigation("Films");
                });

            modelBuilder.Entity("CG.MovieAppEntity.Entities.Film", b =>
                {
                    b.Navigation("FilmActors");

                    b.Navigation("FilmCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
