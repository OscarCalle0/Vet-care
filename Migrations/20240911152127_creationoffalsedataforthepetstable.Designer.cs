﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetCare_BackEnd.Data;

#nullable disable

namespace VetCare_BackEnd.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240911152127_creationoffalsedataforthepetstable")]
    partial class creationoffalsedataforthepetstable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("VetCare_BackEnd.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppointmentTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Available")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasMaxLength(260)
                        .HasColumnType("varchar(260)");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.AppointmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("appointmentTypes");
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("documentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cédula de Ciudadanía"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tarjeta de Identidad"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pasaporte"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Número de Identificación Tributaria"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cédula de Extranjería"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Registro Civil"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Permiso Especial de Permanencia"
                        });
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("BirthDate")
                        .HasMaxLength(10)
                        .HasColumnType("date");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("pets");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            BirthDate = new DateOnly(2024, 2, 9),
                            Breed = "yorkie",
                            Name = "apolo",
                            Sex = "male",
                            Weight = "10lbs",
                            user_id = 1
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateOnly(2024, 3, 12),
                            Breed = "border colie",
                            Name = "princesa",
                            Sex = "female",
                            Weight = "7lbs",
                            user_id = 2
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateOnly(2024, 4, 23),
                            Breed = "pomerania",
                            Name = "cookie",
                            Sex = "male",
                            Weight = "3lbs",
                            user_id = 3
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateOnly(2024, 5, 4),
                            Breed = "bulldog",
                            Name = "motas",
                            Sex = "female",
                            Weight = "12lbs",
                            user_id = 4
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateOnly(2024, 6, 3),
                            Breed = "creole",
                            Name = "coco",
                            Sex = "male",
                            Weight = "6lbs",
                            user_id = 5
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateOnly(2024, 7, 2),
                            Breed = "creole",
                            Name = "romeo",
                            Sex = "female",
                            Weight = "8lbs",
                            user_id = 6
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateOnly(2024, 8, 1),
                            Breed = "yorkie",
                            Name = "kira",
                            Sex = "male",
                            Weight = "9lbs",
                            user_id = 7
                        });
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly?>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateOnly(2024, 5, 20),
                            DocumentNumber = "8mrdd5ljey",
                            DocumentTypeId = 1,
                            Email = "Bret67@hotmail.com",
                            LastName = "Zieme",
                            Name = "Efrain",
                            Password = "GhSOMGIJ14",
                            PhoneNumber = "612 105 05 95",
                            RoleId = 5
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateOnly(2023, 11, 22),
                            DocumentNumber = "4xulqozcyc",
                            DocumentTypeId = 2,
                            Email = "Kaylin.Ruecker@gmail.com",
                            LastName = "Gutmann",
                            Name = "Torrey",
                            Password = "0ILDYJFbnj",
                            PhoneNumber = "278 426 51 98",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateOnly(2024, 1, 5),
                            DocumentNumber = "8wflnq5bgr",
                            DocumentTypeId = 1,
                            Email = "Monte_Kutch62@gmail.com",
                            LastName = "Kuhic",
                            Name = "Darrin",
                            Password = "TpZRUBPuRR",
                            PhoneNumber = "532 886 98 79",
                            RoleId = 4
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateOnly(2023, 11, 15),
                            DocumentNumber = "8gh5sfevl8",
                            DocumentTypeId = 2,
                            Email = "Lilliana.Toy68@hotmail.com",
                            LastName = "Gerhold",
                            Name = "Trisha",
                            Password = "o2PtSGxbCE",
                            PhoneNumber = "222 389 76 51",
                            RoleId = 5
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateOnly(2023, 12, 1),
                            DocumentNumber = "93s02ixwws",
                            DocumentTypeId = 2,
                            Email = "Aiden.Larkin13@gmail.com",
                            LastName = "Cruickshank",
                            Name = "Giovanny",
                            Password = "ChD9X2fewt",
                            PhoneNumber = "189 200 28 18",
                            RoleId = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
