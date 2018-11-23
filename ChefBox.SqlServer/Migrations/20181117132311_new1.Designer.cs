﻿// <auto-generated />
using System;
using ChefBox.SqlServer.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChefBox.SqlServer.Migrations
{
    [DbContext(typeof(ChefBoxDbContext))]
    [Migration("20181117132311_new1")]
    partial class new1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChefBox.Model.Configuration.Setting", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Settings","Configuration");
                });

            modelBuilder.Entity("ChefBox.Model.Cooking.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("IsValid");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories","Cooking");
                });

            modelBuilder.Entity("ChefBox.Model.Cooking.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<int>("IngredientType");

                    b.Property<bool>("IsValid");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Ingredients","Cooking");
                });

            modelBuilder.Entity("ChefBox.Model.Cooking.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("IsCover");

                    b.Property<bool>("IsValid");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<int>("RecipeId");

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Photos","Cooking");
                });

            modelBuilder.Entity("ChefBox.Model.Cooking.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsPublished");

                    b.Property<bool>("IsValid");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("RecipeType");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipes","Cooking");
                });

            modelBuilder.Entity("ChefBox.Model.Cooking.RecipeIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<DateTime>("CreationDate");

                    b.Property<int>("IngredientId");

                    b.Property<bool>("IsValid");

                    b.Property<DateTime>("ModificationDate");

                    b.Property<int>("RecipeId");

                    b.Property<int>("Unit");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients","Cooking");
                });

            modelBuilder.Entity("ChefBox.Model.Cooking.Photo", b =>
                {
                    b.HasOne("ChefBox.Model.Cooking.Recipe", "Recipe")
                        .WithMany("Photos")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ChefBox.Model.Cooking.Recipe", b =>
                {
                    b.HasOne("ChefBox.Model.Cooking.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ChefBox.Model.Cooking.RecipeIngredient", b =>
                {
                    b.HasOne("ChefBox.Model.Cooking.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ChefBox.Model.Cooking.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
