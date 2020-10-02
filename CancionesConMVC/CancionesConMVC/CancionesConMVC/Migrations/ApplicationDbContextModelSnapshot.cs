﻿// <auto-generated />
using System;
using CancionesConMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CancionesConMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CancionesConMVC.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistaId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.HasIndex("ArtistaId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("CancionesConMVC.Models.Artista", b =>
                {
                    b.Property<int>("ArtistaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistaId");

                    b.ToTable("Artistas");
                });

            modelBuilder.Entity("CancionesConMVC.Models.Cancion", b =>
                {
                    b.Property<int>("CancionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CancionId");

                    b.HasIndex("AlbumId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Canciones");
                });

            modelBuilder.Entity("CancionesConMVC.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoporteId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.HasIndex("SoporteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CancionesConMVC.Models.DetalleFactura", b =>
                {
                    b.Property<int>("DetFacturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CancionId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("FacturaId")
                        .HasColumnType("int");

                    b.Property<float>("PrecioUnidad")
                        .HasColumnType("real");

                    b.HasKey("DetFacturaId");

                    b.HasIndex("CancionId");

                    b.HasIndex("FacturaId");

                    b.ToTable("DetalleFacturas");
                });

            modelBuilder.Entity("CancionesConMVC.Models.Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JefeDirecto")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpleadoId");

                    b.HasIndex("JefeDirecto");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("CancionesConMVC.Models.Factura", b =>
                {
                    b.Property<int>("FacturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFactura")
                        .HasColumnType("datetime2");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("FacturaId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("CancionesConMVC.Models.Genero", b =>
                {
                    b.Property<int>("GeneroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GeneroId");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("CancionesConMVC.Models.Album", b =>
                {
                    b.HasOne("CancionesConMVC.Models.Artista", "Artista")
                        .WithMany("Albumes")
                        .HasForeignKey("ArtistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CancionesConMVC.Models.Cancion", b =>
                {
                    b.HasOne("CancionesConMVC.Models.Album", "Album")
                        .WithMany("Canciones")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CancionesConMVC.Models.Genero", "Genero")
                        .WithMany("Canciones")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CancionesConMVC.Models.Cliente", b =>
                {
                    b.HasOne("CancionesConMVC.Models.Empleado", "Empleado")
                        .WithMany("Clientes")
                        .HasForeignKey("SoporteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CancionesConMVC.Models.DetalleFactura", b =>
                {
                    b.HasOne("CancionesConMVC.Models.Cancion", "Cancion")
                        .WithMany()
                        .HasForeignKey("CancionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CancionesConMVC.Models.Factura", "Factura")
                        .WithMany()
                        .HasForeignKey("FacturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CancionesConMVC.Models.Empleado", b =>
                {
                    b.HasOne("CancionesConMVC.Models.Empleado", "EmpleadoJefe")
                        .WithMany("Empleados")
                        .HasForeignKey("JefeDirecto");
                });

            modelBuilder.Entity("CancionesConMVC.Models.Factura", b =>
                {
                    b.HasOne("CancionesConMVC.Models.Cliente", "Cliente")
                        .WithMany("Facturas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
