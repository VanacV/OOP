﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fireflower_backend.Storage;

#nullable disable

namespace fireflower_backend.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230609202007_first_miga")]
    partial class first_miga
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Auth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Auth");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<int>("Sum_cost")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("WithPostCard")
                        .HasColumnType("bit");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("deliveryTime")
                        .HasColumnType("int");

                    b.Property<int>("payment_info")
                        .HasColumnType("int");

                    b.Property<string>("postCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Product_id")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("shop_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Product_Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("product_id")
                        .IsUnique();

                    b.ToTable("Product_Ratings");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shop");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Shop_Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int>("Shop_Id")
                        .HasColumnType("int");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Shop_Id")
                        .IsUnique();

                    b.ToTable("Shop_Rating");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Auth_id")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Auth_id")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Users_With_Mailing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("User_Id")
                        .IsUnique();

                    b.ToTable("Users_Withs_Mailing");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Payment", b =>
                {
                    b.HasOne("fireflower_backend.Storage.Entity.Product", "Product")
                        .WithOne("Payment")
                        .HasForeignKey("fireflower_backend.Storage.Entity.Payment", "Product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fireflower_backend.Storage.Entity.Users", "Users")
                        .WithOne("Payment")
                        .HasForeignKey("fireflower_backend.Storage.Entity.Payment", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Product", b =>
                {
                    b.HasOne("fireflower_backend.Storage.Entity.Shop", "Shop")
                        .WithMany("Products")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Product_Rating", b =>
                {
                    b.HasOne("fireflower_backend.Storage.Entity.Product", "Product")
                        .WithOne("Product_Rating")
                        .HasForeignKey("fireflower_backend.Storage.Entity.Product_Rating", "product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Shop_Rating", b =>
                {
                    b.HasOne("fireflower_backend.Storage.Entity.Shop", "Shop")
                        .WithOne("Shop_Rating")
                        .HasForeignKey("fireflower_backend.Storage.Entity.Shop_Rating", "Shop_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Users", b =>
                {
                    b.HasOne("fireflower_backend.Storage.Entity.Auth", "Auth")
                        .WithOne("Users")
                        .HasForeignKey("fireflower_backend.Storage.Entity.Users", "Auth_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auth");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Users_With_Mailing", b =>
                {
                    b.HasOne("fireflower_backend.Storage.Entity.Users", "Users")
                        .WithOne("Malling")
                        .HasForeignKey("fireflower_backend.Storage.Entity.Users_With_Mailing", "User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Auth", b =>
                {
                    b.Navigation("Users")
                        .IsRequired();
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Product", b =>
                {
                    b.Navigation("Payment")
                        .IsRequired();

                    b.Navigation("Product_Rating")
                        .IsRequired();
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Shop", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("Shop_Rating")
                        .IsRequired();
                });

            modelBuilder.Entity("fireflower_backend.Storage.Entity.Users", b =>
                {
                    b.Navigation("Malling")
                        .IsRequired();

                    b.Navigation("Payment")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
