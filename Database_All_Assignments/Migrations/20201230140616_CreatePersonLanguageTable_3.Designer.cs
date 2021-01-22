﻿// <auto-generated />
using System;
using Database_All_Assignments.Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Database_All_Assignments.Migrations
{
    [DbContext(typeof(IdentityContentDbContext))]
    [Migration("20201230140616_CreatePersonLanguageTable_3")]
    partial class CreatePersonLanguageTable_3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Database_All_Assignments.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("States")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("GetCitiesList");
                });

            modelBuilder.Entity("Database_All_Assignments.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("GetCountriesList");
                });

            modelBuilder.Entity("Database_All_Assignments.Models.Language", b =>
                {
                    b.Property<int>("LanguageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonLanguagePersonLangID")
                        .HasColumnType("int");

                    b.HasKey("LanguageID");

                    b.HasIndex("PersonLanguagePersonLangID");

                    b.ToTable("GetLanguageList");
                });

            modelBuilder.Entity("Database_All_Assignments.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<int?>("PersonLanguagePersonLangID")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("PersonID");

                    b.HasIndex("CityId");

                    b.HasIndex("PersonLanguagePersonLangID");

                    b.ToTable("GetPeopleList");
                });

            modelBuilder.Entity("Database_All_Assignments.Models.PersonLanguage", b =>
                {
                    b.Property<int>("PersonLangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("PersonLangID");

                    b.ToTable("PersonLanguage");
                });

            modelBuilder.Entity("Database_All_Assignments.Models.City", b =>
                {
                    b.HasOne("Database_All_Assignments.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("Database_All_Assignments.Models.Language", b =>
                {
                    b.HasOne("Database_All_Assignments.Models.PersonLanguage", null)
                        .WithMany("Language")
                        .HasForeignKey("PersonLanguagePersonLangID");
                });

            modelBuilder.Entity("Database_All_Assignments.Models.Person", b =>
                {
                    b.HasOne("Database_All_Assignments.Models.City", "City")
                        .WithMany("PersonInCity")
                        .HasForeignKey("CityId");

                    b.HasOne("Database_All_Assignments.Models.PersonLanguage", null)
                        .WithMany("Person")
                        .HasForeignKey("PersonLanguagePersonLangID");
                });
#pragma warning restore 612, 618
        }
    }
}
