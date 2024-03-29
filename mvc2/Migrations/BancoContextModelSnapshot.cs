﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mvc2.Data;

#nullable disable

namespace mvc2.Migrations
{
    [DbContext(typeof(BancoContext))]
    partial class BancoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("mvc2.Models.ClienteModel", b =>
                {
                    b.Property<int>("CLI_CODIGON")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CLI_CODIGON"));

                    b.Property<string>("CLI_CGC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CLI_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CLI_CODIGON");

                    b.ToTable("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
