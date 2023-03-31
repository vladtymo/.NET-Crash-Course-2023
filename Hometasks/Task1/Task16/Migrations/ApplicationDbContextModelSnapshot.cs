﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task16;

#nullable disable

namespace Task16.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Task16.Entities.AlbumEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ArtistFK")
                        .HasColumnType("bigint");

                    b.Property<long>("ArtistId")
                        .HasColumnType("bigint");

                    b.Property<long>("GenreFK")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseYear")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ArtistFK");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreFK");

                    b.ToTable("Albums", (string)null);
                });

            modelBuilder.Entity("Task16.Entities.ArtistEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CountryFK")
                        .HasColumnType("bigint");

                    b.Property<long>("CountyId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryFK");

                    b.HasIndex("CountyId");

                    b.ToTable("Artists", (string)null);
                });

            modelBuilder.Entity("Task16.Entities.CategoryEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("Task16.Entities.CountyEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries", (string)null);
                });

            modelBuilder.Entity("Task16.Entities.GenreEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres", (string)null);
                });

            modelBuilder.Entity("Task16.Entities.PlaylistEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CategoryFK")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryFK");

                    b.ToTable("Playlists", (string)null);
                });

            modelBuilder.Entity("Task16.Entities.PlaylistTracksEntity", b =>
                {
                    b.Property<long>("PlaylistFK")
                        .HasColumnType("bigint");

                    b.Property<long>("TrackFK")
                        .HasColumnType("bigint");

                    b.HasKey("PlaylistFK", "TrackFK");

                    b.HasIndex("TrackFK");

                    b.ToTable("Playlist tracks", (string)null);
                });

            modelBuilder.Entity("Task16.Entities.TrackEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AlbumFK")
                        .HasColumnType("bigint");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumFK");

                    b.ToTable("Tracks", (string)null);
                });

            modelBuilder.Entity("Task16.Entities.AlbumEntity", b =>
                {
                    b.HasOne("Task16.Entities.ArtistEntity", null)
                        .WithMany("Albums")
                        .HasForeignKey("ArtistFK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Task16.Entities.ArtistEntity", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Task16.Entities.GenreEntity", "Genre")
                        .WithMany("Albums")
                        .HasForeignKey("GenreFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Task16.Entities.ArtistEntity", b =>
                {
                    b.HasOne("Task16.Entities.CountyEntity", null)
                        .WithMany("Artists")
                        .HasForeignKey("CountryFK")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Task16.Entities.CountyEntity", "County")
                        .WithMany()
                        .HasForeignKey("CountyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("County");
                });

            modelBuilder.Entity("Task16.Entities.PlaylistEntity", b =>
                {
                    b.HasOne("Task16.Entities.CategoryEntity", "Category")
                        .WithMany("Playlists")
                        .HasForeignKey("CategoryFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Task16.Entities.PlaylistTracksEntity", b =>
                {
                    b.HasOne("Task16.Entities.PlaylistEntity", "Playlists")
                        .WithMany("PlaylistTracks")
                        .HasForeignKey("PlaylistFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Task16.Entities.TrackEntity", "Tracks")
                        .WithMany("PlaylistTracks")
                        .HasForeignKey("TrackFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Playlists");

                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Task16.Entities.TrackEntity", b =>
                {
                    b.HasOne("Task16.Entities.AlbumEntity", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("Task16.Entities.AlbumEntity", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Task16.Entities.ArtistEntity", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Task16.Entities.CategoryEntity", b =>
                {
                    b.Navigation("Playlists");
                });

            modelBuilder.Entity("Task16.Entities.CountyEntity", b =>
                {
                    b.Navigation("Artists");
                });

            modelBuilder.Entity("Task16.Entities.GenreEntity", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Task16.Entities.PlaylistEntity", b =>
                {
                    b.Navigation("PlaylistTracks");
                });

            modelBuilder.Entity("Task16.Entities.TrackEntity", b =>
                {
                    b.Navigation("PlaylistTracks");
                });
#pragma warning restore 612, 618
        }
    }
}
