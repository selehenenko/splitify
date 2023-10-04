﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Splitify.Identity.Infrastructure;

#nullable disable

namespace Splitify.Identity.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231004193605_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Splitify.Identity.Domain.UserAggregate", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Verified")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Splitify.Identity.Domain.UserAggregate", b =>
                {
                    b.OwnsOne("Splitify.Identity.Domain.UserPassword", "Password", b1 =>
                        {
                            b1.Property<string>("UserAggregateId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<byte[]>("Hash")
                                .IsRequired()
                                .HasColumnType("varbinary(max)");

                            b1.Property<byte[]>("Salt")
                                .IsRequired()
                                .HasColumnType("varbinary(max)");

                            b1.HasKey("UserAggregateId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserAggregateId");
                        });

                    b.OwnsOne("Splitify.Identity.Domain.VerificationCode", "VerificationCode", b1 =>
                        {
                            b1.Property<string>("UserAggregateId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Code")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("datetime2");

                            b1.HasKey("UserAggregateId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserAggregateId");
                        });

                    b.Navigation("Password")
                        .IsRequired();

                    b.Navigation("VerificationCode")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
