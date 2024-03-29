﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shrooms.Models;

namespace Shrooms.Migrations
{
    [DbContext(typeof(ShroomsContext))]
    partial class ShroomsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Shrooms.Models.Mushroom", b =>
                {
                    b.Property<int>("MushroomId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CapDimensions");

                    b.Property<string>("Family");

                    b.Property<string>("Name");

                    b.Property<bool>("Poisonous");

                    b.Property<bool>("Psycho");

                    b.Property<string>("Region");

                    b.Property<string>("SporePrintDetails");

                    b.Property<int>("StemDimensions");

                    b.Property<string>("VisualDetails");

                    b.HasKey("MushroomId");

                    b.ToTable("Mushrooms");

                    b.HasData(
                        new
                        {
                            MushroomId = 1,
                            CapDimensions = 9,
                            Family = "Pluteaceae",
                            Name = "Fly Amanita",
                            Poisonous = true,
                            Psycho = true,
                            Region = "North America, Europe, Asia",
                            SporePrintDetails = "na",
                            StemDimensions = 13,
                            VisualDetails = "white stem, red cap with white spots"
                        },
                        new
                        {
                            MushroomId = 2,
                            CapDimensions = 6,
                            Family = "Stinkhorn",
                            Name = "Clathrus Ruber",
                            Poisonous = true,
                            Psycho = false,
                            Region = "Southern Europe, Macronesia, Western Turkey, North Africa, Western Asia",
                            SporePrintDetails = "N/A",
                            StemDimensions = 14,
                            VisualDetails = "Round or oval hollow sphere, with latticed branches. Red or orange"
                        },
                        new
                        {
                            MushroomId = 3,
                            CapDimensions = 3,
                            Family = "Hymenogastraceae",
                            Name = "Psilocybe cyanescens",
                            Poisonous = false,
                            Psycho = true,
                            Region = "Pacific Northwest, Western Europe, Central Europe, New Zealand and west Asia",
                            SporePrintDetails = "blackish-brown to purple",
                            StemDimensions = 7,
                            VisualDetails = "Cap is caramel to chestnut-brown when moist, fading to pale buff or slightly yellowish when dried. Stems are wavy. Parts of mushroom can turn blue when touched or disturbed"
                        },
                        new
                        {
                            MushroomId = 4,
                            CapDimensions = 29,
                            Family = "Polyporaceae",
                            Name = "Polypore",
                            Poisonous = false,
                            Psycho = false,
                            Region = "Globally in forested areas",
                            SporePrintDetails = "N/A",
                            StemDimensions = 29,
                            VisualDetails = "woody, shelf-like form, projecting straight out of tree trunks or logs."
                        });
                });

            modelBuilder.Entity("Shrooms.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Token");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
