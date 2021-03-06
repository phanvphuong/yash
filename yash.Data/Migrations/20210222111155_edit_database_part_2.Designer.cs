﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using yash.Data.EF;

namespace yash.Data.Migrations
{
    [DbContext(typeof(YashDbContext))]
    [Migration("20210222111155_edit_database_part_2")]
    partial class edit_database_part_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("yash.Data.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("Role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "cmt8",
                            Email = "minhl93172@gmail.com",
                            FirstName = "Minh",
                            LastName = "Le",
                            Password = "123",
                            Role = true
                        },
                        new
                        {
                            Id = 2,
                            Address = "cmt8",
                            Email = "tuan123@gmail.com",
                            FirstName = "Tuan",
                            LastName = "Bui",
                            Password = "123",
                            Role = false
                        });
                });

            modelBuilder.Entity("yash.Data.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("yash.Data.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("yash.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Anniversary"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Birthday"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Wedding"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Engagement"
                        });
                });

            modelBuilder.Entity("yash.Data.Entities.Certification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Certifications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LinkUrl = "http://www.bis.org.in/",
                            Name = "BIS Hallmark"
                        },
                        new
                        {
                            Id = 2,
                            LinkUrl = "https://sgl-labs.com/",
                            Name = "SGL"
                        },
                        new
                        {
                            Id = 3,
                            LinkUrl = "https://www.igi.org/",
                            Name = "IGI"
                        });
                });

            modelBuilder.Entity("yash.Data.Entities.Diamond", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiamondShape")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Diamonds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiamondShape = "round",
                            Price = 7291f
                        },
                        new
                        {
                            Id = 2,
                            DiamondShape = "princess",
                            Price = 4799f
                        },
                        new
                        {
                            Id = 3,
                            DiamondShape = "oval",
                            Price = 5362f
                        },
                        new
                        {
                            Id = 4,
                            DiamondShape = "cushion",
                            Price = 4229f
                        },
                        new
                        {
                            Id = 5,
                            DiamondShape = "pear",
                            Price = 5802f
                        },
                        new
                        {
                            Id = 6,
                            DiamondShape = "radiant",
                            Price = 4443f
                        },
                        new
                        {
                            Id = 7,
                            DiamondShape = "emerald",
                            Price = 4476f
                        },
                        new
                        {
                            Id = 8,
                            DiamondShape = "asscher",
                            Price = 4137f
                        },
                        new
                        {
                            Id = 9,
                            DiamondShape = "marquise",
                            Price = 5596f
                        },
                        new
                        {
                            Id = 10,
                            DiamondShape = "heart",
                            Price = 5536f
                        });
                });

            modelBuilder.Entity("yash.Data.Entities.Gold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GoldCarat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Golds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GoldCarat = "14kt",
                            Price = 1034.8f
                        },
                        new
                        {
                            Id = 2,
                            GoldCarat = "18kt",
                            Price = 1338.9f
                        });
                });

            modelBuilder.Entity("yash.Data.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CertifyId")
                        .HasColumnType("int");

                    b.Property<float>("DiamondCarat")
                        .HasColumnType("real");

                    b.Property<int>("DiamondId")
                        .HasColumnType("int");

                    b.Property<int>("GoldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2);

                    b.Property<float>("GoldWeight")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("real")
                        .HasDefaultValue(1f);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("RingSizeId")
                        .HasColumnType("int");

                    b.Property<float>("TotalMaking")
                        .HasColumnType("real");

                    b.Property<int>("WastageInPercentage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(20);

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CertifyId");

                    b.HasIndex("DiamondId");

                    b.HasIndex("GoldId");

                    b.HasIndex("ProductId");

                    b.HasIndex("RingSizeId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("yash.Data.Entities.ItemImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("ItemImageUrl")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemImages");
                });

            modelBuilder.Entity("yash.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ShipEmail")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ShipPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("yash.Data.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("yash.Data.Entities.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "RINGS"
                        },
                        new
                        {
                            Id = 2,
                            Name = "EARRINGS"
                        },
                        new
                        {
                            Id = 3,
                            Name = "PENDANTS"
                        });
                });

            modelBuilder.Entity("yash.Data.Entities.RingSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SizeNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RingSizes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SizeNumber = 6
                        },
                        new
                        {
                            Id = 2,
                            SizeNumber = 7
                        },
                        new
                        {
                            Id = 3,
                            SizeNumber = 8
                        },
                        new
                        {
                            Id = 4,
                            SizeNumber = 9
                        },
                        new
                        {
                            Id = 5,
                            SizeNumber = 10
                        },
                        new
                        {
                            Id = 6,
                            SizeNumber = 11
                        },
                        new
                        {
                            Id = 7,
                            SizeNumber = 12
                        },
                        new
                        {
                            Id = 8,
                            SizeNumber = 13
                        },
                        new
                        {
                            Id = 9,
                            SizeNumber = 14
                        },
                        new
                        {
                            Id = 10,
                            SizeNumber = 15
                        },
                        new
                        {
                            Id = 11,
                            SizeNumber = 16
                        },
                        new
                        {
                            Id = 12,
                            SizeNumber = 17
                        },
                        new
                        {
                            Id = 13,
                            SizeNumber = 18
                        },
                        new
                        {
                            Id = 14,
                            SizeNumber = 19
                        },
                        new
                        {
                            Id = 15,
                            SizeNumber = 20
                        },
                        new
                        {
                            Id = 16,
                            SizeNumber = 21
                        },
                        new
                        {
                            Id = 17,
                            SizeNumber = 22
                        },
                        new
                        {
                            Id = 18,
                            SizeNumber = 23
                        },
                        new
                        {
                            Id = 19,
                            SizeNumber = 24
                        },
                        new
                        {
                            Id = 20,
                            SizeNumber = 25
                        },
                        new
                        {
                            Id = 21,
                            SizeNumber = 26
                        },
                        new
                        {
                            Id = 22,
                            SizeNumber = 27
                        },
                        new
                        {
                            Id = 23,
                            SizeNumber = 28
                        },
                        new
                        {
                            Id = 24,
                            SizeNumber = 29
                        },
                        new
                        {
                            Id = 25,
                            SizeNumber = 30
                        });
                });

            modelBuilder.Entity("yash.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CurrentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("yash.Data.Entities.Cart", b =>
                {
                    b.HasOne("yash.Data.Entities.Item", "Item")
                        .WithMany("Carts")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yash.Data.Entities.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("yash.Data.Entities.Item", b =>
                {
                    b.HasOne("yash.Data.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("yash.Data.Entities.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yash.Data.Entities.Certification", "Certification")
                        .WithMany("Items")
                        .HasForeignKey("CertifyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yash.Data.Entities.Diamond", "Diamond")
                        .WithMany("Items")
                        .HasForeignKey("DiamondId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yash.Data.Entities.Gold", "Gold")
                        .WithMany("Items")
                        .HasForeignKey("GoldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yash.Data.Entities.ProductType", "Product")
                        .WithMany("Items")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yash.Data.Entities.RingSize", "Size")
                        .WithMany()
                        .HasForeignKey("RingSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("yash.Data.Entities.ItemImage", b =>
                {
                    b.HasOne("yash.Data.Entities.Item", "Item")
                        .WithMany("ItemImages")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("yash.Data.Entities.Order", b =>
                {
                    b.HasOne("yash.Data.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("yash.Data.Entities.OrderDetail", b =>
                {
                    b.HasOne("yash.Data.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yash.Data.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
