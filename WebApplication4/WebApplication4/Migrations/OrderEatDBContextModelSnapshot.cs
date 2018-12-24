﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Migrations
{
    [DbContext(typeof(OrderEatDBContext))]
    partial class OrderEatDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication4.Models.Clientes", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Cedula")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("PersonaId");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("WebApplication4.Models.Comidas", b =>
                {
                    b.Property<int>("ComidaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.Property<int>("Platos");

                    b.Property<int>("Precio");

                    b.HasKey("ComidaId");

                    b.ToTable("comidas");
                });

            modelBuilder.Entity("WebApplication4.Models.Factura", b =>
                {
                    b.Property<int>("FacturaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Clientes");

                    b.Property<int?>("Comidas");

                    b.Property<DateTime>("Fecha");

                    b.HasKey("FacturaId");

                    b.HasIndex("Clientes");

                    b.HasIndex("Comidas");

                    b.ToTable("facturas");
                });

            modelBuilder.Entity("WebApplication4.Models.Personas", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Pass")
                        .IsRequired();

                    b.Property<string>("Usuario")
                        .IsRequired();

                    b.HasKey("PersonaId");

                    b.ToTable("personas");
                });

            modelBuilder.Entity("WebApplication4.Models.Factura", b =>
                {
                    b.HasOne("WebApplication4.Models.Personas", "ClienteFk")
                        .WithMany()
                        .HasForeignKey("Clientes");

                    b.HasOne("WebApplication4.Models.Comidas", "ComidaFk")
                        .WithMany()
                        .HasForeignKey("Comidas");
                });
#pragma warning restore 612, 618
        }
    }
}