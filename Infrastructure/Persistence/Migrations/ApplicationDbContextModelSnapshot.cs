﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Domain.Entities.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("AlbumUrl")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<Guid>("ArtistId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Label")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("LargeThumbnail")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("MediumThumbnail")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<int?>("Rating")
                        .HasColumnType("integer");

                    b.Property<string>("SmallThumbnail")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ThumbnailTag")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("Domain.Entities.Artist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasColumnType("character varying(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Biography")
                        .HasColumnType("character varying(4096)")
                        .HasMaxLength(4096);

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LargeThumbnail")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("SmallThumbnail")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ThumbnailTag")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("YearActive")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("Domain.Entities.ArtistBasicInfo", b =>
                {
                    b.Property<Guid>("ArtistId")
                        .HasColumnType("uuid");

                    b.Property<string>("AlsoKnownAs")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Born")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Died")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.HasKey("ArtistId");

                    b.ToTable("ArtistBasicInfo");
                });

            modelBuilder.Entity("Domain.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(4096)")
                        .HasMaxLength(4096);

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Domain.Entities.Track", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AlbumId")
                        .HasColumnType("uuid");

                    b.Property<string>("Composer")
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Duration")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Featuring")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Performer")
                        .HasColumnType("text");

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Track");
                });

            modelBuilder.Entity("Domain.Entities.Album", b =>
                {
                    b.HasOne("Domain.Entities.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .HasConstraintName("FK_Album_ToArtist")
                        .IsRequired();

                    b.HasOne("Domain.Entities.Genre", "Genre")
                        .WithMany("Albums")
                        .HasForeignKey("GenreId")
                        .HasConstraintName("FK_Album_ToGenre")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.ArtistBasicInfo", b =>
                {
                    b.HasOne("Domain.Entities.Artist", "Artist")
                        .WithOne("ArtistBasicInfo")
                        .HasForeignKey("Domain.Entities.ArtistBasicInfo", "ArtistId")
                        .HasConstraintName("FK_ArtistBasicInfo_ToArtist")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Track", b =>
                {
                    b.HasOne("Domain.Entities.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId")
                        .HasConstraintName("FK_Track_ToAlbum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
