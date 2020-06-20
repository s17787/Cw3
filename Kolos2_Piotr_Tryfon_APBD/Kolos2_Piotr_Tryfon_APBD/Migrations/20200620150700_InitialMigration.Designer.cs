﻿// <auto-generated />
using System;
using Kolos2_Piotr_Tryfon_APBD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kolos2_Piotr_Tryfon_APBD.Migrations
{
    [DbContext(typeof(HomeController))]
    [Migration("20200620150700_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kolos2_Piotr_Tryfon_APBD.Models.EventOrganiser", b =>
                {
                    b.Property<int>("IdEvent")
                        .HasColumnType("int");

                    b.Property<int>("IdOrganiser")
                        .HasColumnType("int");

                    b.HasKey("IdEvent", "IdOrganiser");

                    b.HasIndex("IdOrganiser");

                    b.ToTable("EventOrganiser");
                });

            modelBuilder.Entity("Kolos2_Piotr_Tryfon_APBD.Models.Organiser", b =>
                {
                    b.Property<int>("IdOrganiser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int?>("OrganiserIdOrganiser")
                        .HasColumnType("int");

                    b.HasKey("IdOrganiser");

                    b.HasIndex("OrganiserIdOrganiser");

                    b.ToTable("Organiser");
                });

            modelBuilder.Entity("Kolos2_Piotr_Tryfon_APBD.Models.EventOrganiser", b =>
                {
                    b.HasOne("Kolos2_Piotr_Tryfon_APBD.Models.Organiser", "Organiser")
                        .WithMany()
                        .HasForeignKey("IdOrganiser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Kolos2_Piotr_Tryfon_APBD.Models.Organiser", b =>
                {
                    b.HasOne("Kolos2_Piotr_Tryfon_APBD.Models.Organiser", null)
                        .WithMany("EventOrganiser")
                        .HasForeignKey("OrganiserIdOrganiser");
                });
#pragma warning restore 612, 618
        }
    }
}
