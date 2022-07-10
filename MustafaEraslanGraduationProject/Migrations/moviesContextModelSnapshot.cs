﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MustafaEraslanGraduationProject;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MustafaEraslanGraduationProject.Migrations
{
    [DbContext(typeof(moviesContext))]
    partial class moviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MustafaEraslanGraduationProject.Entities.Mytable", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Adult")
                        .IsRequired()
                        .HasMaxLength(126)
                        .HasColumnType("character varying(126)")
                        .HasColumnName("adult");

                    b.Property<string>("BelongsToCollection")
                        .HasMaxLength(184)
                        .HasColumnType("character varying(184)")
                        .HasColumnName("belongs_to_collection");

                    b.Property<string>("Budget")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)")
                        .HasColumnName("budget");

                    b.Property<string>("Genres")
                        .IsRequired()
                        .HasMaxLength(264)
                        .HasColumnType("character varying(264)")
                        .HasColumnName("genres");

                    b.Property<string>("Homepage")
                        .HasMaxLength(242)
                        .HasColumnType("character varying(242)")
                        .HasColumnName("homepage");

                    b.Property<string>("ImdbId")
                        .HasMaxLength(9)
                        .HasColumnType("character varying(9)")
                        .HasColumnName("imdb_id");

                    b.Property<string>("OriginalLanguage")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)")
                        .HasColumnName("original_language");

                    b.Property<string>("OriginalTitle")
                        .IsRequired()
                        .HasMaxLength(109)
                        .HasColumnType("character varying(109)")
                        .HasColumnName("original_title");

                    b.Property<string>("Overview")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnName("overview");

                    b.Property<string>("Popularity")
                        .HasMaxLength(21)
                        .HasColumnType("character varying(21)")
                        .HasColumnName("popularity");

                    b.Property<string>("PosterPath")
                        .HasMaxLength(35)
                        .HasColumnType("character varying(35)")
                        .HasColumnName("poster_path");

                    b.Property<string>("ProductionCompanies")
                        .HasMaxLength(1252)
                        .HasColumnType("character varying(1252)")
                        .HasColumnName("production_companies");

                    b.Property<string>("ProductionCountries")
                        .HasMaxLength(1039)
                        .HasColumnType("character varying(1039)")
                        .HasColumnName("production_countries");

                    b.Property<string>("ReleaseDate")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("release_date");

                    b.Property<int?>("Revenue")
                        .HasColumnType("integer")
                        .HasColumnName("revenue");

                    b.Property<decimal?>("Runtime")
                        .HasPrecision(6, 1)
                        .HasColumnType("numeric(6,1)")
                        .HasColumnName("runtime");

                    b.Property<string>("SpokenLanguages")
                        .HasMaxLength(765)
                        .HasColumnType("character varying(765)")
                        .HasColumnName("spoken_languages");

                    b.Property<string>("Status")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("status");

                    b.Property<string>("Tagline")
                        .HasMaxLength(297)
                        .HasColumnType("character varying(297)")
                        .HasColumnName("tagline");

                    b.Property<string>("Title")
                        .HasMaxLength(105)
                        .HasColumnType("character varying(105)")
                        .HasColumnName("title");

                    b.Property<string>("Video")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)")
                        .HasColumnName("video");

                    b.Property<decimal?>("VoteAverage")
                        .HasPrecision(4, 1)
                        .HasColumnType("numeric(4,1)")
                        .HasColumnName("vote_average");

                    b.Property<int?>("VoteCount")
                        .HasColumnType("integer")
                        .HasColumnName("vote_count");

                    b.HasKey("Id");

                    b.ToTable("mytable", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
