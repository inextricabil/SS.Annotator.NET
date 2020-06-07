﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RTCoViD.Data;

namespace RTCoViD.Migrations
{
    [DbContext(typeof(RTCoViDContext))]
    partial class RTCoViDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RTCoViD.Models.Tweet", b =>
                {
                    b.Property<string>("TweetId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Location");

                    b.Property<string>("Text");

                    b.Property<string>("UserId");

                    b.Property<bool>("Verified");

                    b.HasKey("TweetId");

                    b.ToTable("Tweet");
                });
#pragma warning restore 612, 618
        }
    }
}
