﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shrooms.Models;

namespace Shrooms.Migrations
{
    [DbContext(typeof(ShroomsContext))]
    [Migration("20191028182322_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Name");

                    b.Property<bool>("Poisonous");

                    b.Property<bool>("Psycho");

                    b.Property<string>("Region");

                    b.Property<string>("SporePrintDetails");

                    b.Property<int>("StemDimensions");

                    b.Property<string>("VisualDetails");

                    b.Property<string>("family");

                    b.HasKey("MushroomId");

                    b.ToTable("Mushrooms");
                });
#pragma warning restore 612, 618
        }
    }
}
