﻿// <auto-generated />
using System;
using DBOperationsWithEFCoreApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DBOperationsWithEFCoreApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241221084417_addedLanguageTable")]
    partial class addedLanguageTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DBOperationsWithEFCoreApp.Data.Book", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Languageid")
                        .HasColumnType("int");

                    b.Property<int>("NoOfPages")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("Languageid");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DBOperationsWithEFCoreApp.Data.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Description")
                        .HasColumnType("int");

                    b.Property<int>("Title")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("DBOperationsWithEFCoreApp.Data.Book", b =>
                {
                    b.HasOne("DBOperationsWithEFCoreApp.Data.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("Languageid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("DBOperationsWithEFCoreApp.Data.Language", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
