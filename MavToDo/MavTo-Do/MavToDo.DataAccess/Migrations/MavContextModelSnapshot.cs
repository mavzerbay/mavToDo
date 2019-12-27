﻿// <auto-generated />
using System;
using MavToDo.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MavToDo.DataAccess.Migrations
{
    [DbContext(typeof(MavContext))]
    partial class MavContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MavToDo.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MavToDo.Entities.Concrete.ThingsToDo", b =>
                {
                    b.Property<int>("ThingsToDoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("ThingsToDoColor");

                    b.Property<DateTime>("ThingsToDoEnd");

                    b.Property<string>("ThingsToDoName")
                        .IsRequired();

                    b.Property<DateTime>("ThingsToDoStart");

                    b.Property<string>("UserId");

                    b.HasKey("ThingsToDoId");

                    b.ToTable("ThingsToDos");
                });
#pragma warning restore 612, 618
        }
    }
}
