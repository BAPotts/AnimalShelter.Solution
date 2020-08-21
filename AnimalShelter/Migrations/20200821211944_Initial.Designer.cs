﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20200821211944_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Breed")
                        .IsRequired();

                    b.Property<string>("Color")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("CatId");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            CatId = 1,
                            Age = 3,
                            Breed = "Domestic Shorthair",
                            Color = "Black",
                            Gender = "Female",
                            Name = "Frankie"
                        },
                        new
                        {
                            CatId = 2,
                            Age = 3,
                            Breed = "Domestic Mediumhair",
                            Color = "Black",
                            Gender = "Male",
                            Name = "Jasper"
                        },
                        new
                        {
                            CatId = 3,
                            Age = 5,
                            Breed = "Domestic Longhair",
                            Color = "Tabby",
                            Gender = "Female",
                            Name = "Snugglepuss"
                        },
                        new
                        {
                            CatId = 4,
                            Age = 5,
                            Breed = "Domestic Shorthair",
                            Color = "Tabby",
                            Gender = "Male",
                            Name = "Bubsy"
                        },
                        new
                        {
                            CatId = 5,
                            Age = 7,
                            Breed = "Domestic Shorthair",
                            Color = "Grey",
                            Gender = "Female",
                            Name = "Toots"
                        },
                        new
                        {
                            CatId = 6,
                            Age = 5,
                            Breed = "Bombay",
                            Color = "Calico",
                            Gender = "Female",
                            Name = "Scout"
                        },
                        new
                        {
                            CatId = 7,
                            Age = 14,
                            Breed = "Domestic Shorthair",
                            Color = "White",
                            Gender = "Male",
                            Name = "George"
                        },
                        new
                        {
                            CatId = 8,
                            Age = 17,
                            Breed = "Domestic Shorthair",
                            Color = "Black",
                            Gender = "Female",
                            Name = "Gypsy"
                        },
                        new
                        {
                            CatId = 9,
                            Age = 4,
                            Breed = "Siamese",
                            Color = "Orange",
                            Gender = "Male",
                            Name = "Hank"
                        },
                        new
                        {
                            CatId = 10,
                            Age = 5,
                            Breed = "Domestic Shorthair",
                            Color = "Black",
                            Gender = "Male",
                            Name = "Jiji"
                        },
                        new
                        {
                            CatId = 11,
                            Age = 8,
                            Breed = "Ragdoll",
                            Color = "Flame Point",
                            Gender = "Female",
                            Name = "Sassy"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Breed")
                        .IsRequired();

                    b.Property<string>("Color")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("DogId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = 1,
                            Age = 8,
                            Breed = "Puggle",
                            Color = "Black",
                            Gender = "Female",
                            Name = "Violet"
                        },
                        new
                        {
                            DogId = 2,
                            Age = 3,
                            Breed = "Terrier Mix",
                            Color = "Grey",
                            Gender = "Female",
                            Name = "Ella"
                        },
                        new
                        {
                            DogId = 3,
                            Age = 10,
                            Breed = "Terrier Mix",
                            Color = "Brown",
                            Gender = "Male",
                            Name = "Huckleberry"
                        },
                        new
                        {
                            DogId = 4,
                            Age = 7,
                            Breed = "Chesapeake Bay Retriever",
                            Color = "Brown",
                            Gender = "Male",
                            Name = "Rye"
                        },
                        new
                        {
                            DogId = 5,
                            Age = 1,
                            Breed = "Great Dane",
                            Color = "White",
                            Gender = "Male",
                            Name = "Roger"
                        },
                        new
                        {
                            DogId = 6,
                            Age = 6,
                            Breed = "Wolfhound",
                            Color = "Tawny",
                            Gender = "Female",
                            Name = "Fido"
                        },
                        new
                        {
                            DogId = 7,
                            Age = 3,
                            Breed = "Jack Russell Terrier",
                            Color = "Spotted",
                            Gender = "Male",
                            Name = "Russell"
                        },
                        new
                        {
                            DogId = 8,
                            Age = 1,
                            Breed = "Boxer",
                            Color = "Pink",
                            Gender = "Male",
                            Name = "Chance"
                        },
                        new
                        {
                            DogId = 9,
                            Age = 12,
                            Breed = "Golden Retriever",
                            Color = "Gold",
                            Gender = "Male",
                            Name = "Shadow"
                        },
                        new
                        {
                            DogId = 10,
                            Age = 2,
                            Breed = "Chesapeake Bay Retriever",
                            Color = "Brown",
                            Gender = "Male",
                            Name = "Jake"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}