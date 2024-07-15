﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Do_an_mon_hoc.Models;

public partial class MiniMarketContext : DbContext
{
    public MiniMarketContext(DbContextOptions<MiniMarketContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartItem> CartItems { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryGroup> CategoryGroups { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<Gallery> Galleries { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<SaleEvent> SaleEvents { get; set; }

    public virtual DbSet<SaleItem> SaleItems { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Wishlist> Wishlists { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>(entity =>
        {
            entity.ToTable("brand");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue((byte)0)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Thumbnail)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("thumbnail");
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cart__3213E83FD2595A7B");

            entity.ToTable("Cart");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Saved).HasColumnName("saved");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Carts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Cart__user_id__1EF99443");
        });

        modelBuilder.Entity<CartItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cart_ite__3213E83F693DD222");

            entity.ToTable("Cart_item");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CartId).HasColumnName("cart_id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue((byte)0)
                .HasColumnName("is_deleted");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Total).HasColumnName("total");

            entity.HasOne(d => d.Cart).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.CartId)
                .HasConstraintName("FK__Cart_item__cart___1FEDB87C");

            entity.HasOne(d => d.Product).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Cart_item__produ__20E1DCB5");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("category");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CategoryGroupId).HasColumnName("category_group_id");
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue((byte)0)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Thumbnail)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("thumbnail");

            entity.HasOne(d => d.CategoryGroup).WithMany(p => p.Categories)
                .HasForeignKey(d => d.CategoryGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__category__catego__21D600EE");
        });

        modelBuilder.Entity<CategoryGroup>(entity =>
        {
            entity.ToTable("category_group");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue((byte)0)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Thumbnail)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("thumbnail");
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Feedback__3213E83FAA282CA8");

            entity.ToTable("Feedback");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasColumnName("email");
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .HasColumnName("fullname");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .HasColumnName("message");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phone_number");
            entity.Property(e => e.Subject)
                .HasMaxLength(200)
                .HasColumnName("subject");
        });

        modelBuilder.Entity<Gallery>(entity =>
        {
            entity.ToTable("gallery");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue((byte)0)
                .HasColumnName("is_deleted");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Sort).HasColumnName("sort");
            entity.Property(e => e.Thumbnail)
                .IsRequired()
                .HasMaxLength(300)
                .HasColumnName("thumbnail");

            entity.HasOne(d => d.Product).WithMany(p => p.Galleries)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__gallery__product__22CA2527");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK___Order__3213E83F390D5E6D");

            entity.ToTable("_Order");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .HasColumnName("note");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(200)
                .HasColumnName("payment_method");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK___Order__user_id__1E05700A");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Order_it__3213E83F660D1716");

            entity.ToTable("Order_item");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue((byte)0)
                .HasColumnName("is_deleted");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Total).HasColumnName("total");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__Order_ite__order__23BE4960");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Order_ite__produ__24B26D99");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("product");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Article)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("article");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Canonical)
                .HasMaxLength(50)
                .HasColumnName("canonical");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DeletedAt)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Description)
                .HasMaxLength(1550)
                .HasColumnName("description");
            entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");
            entity.Property(e => e.DiscountPrice).HasColumnName("discount_price");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue((byte)0)
                .HasColumnName("is_deleted");
            entity.Property(e => e.IsFeatured).HasColumnName("is_featured");
            entity.Property(e => e.IsVisible).HasColumnName("is_visible");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.RegPrice).HasColumnName("reg_price");
            entity.Property(e => e.Thumbnail)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("thumbnail");
            entity.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("unit");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Brand).WithMany(p => p.Products)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__product__brand_i__25A691D2");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__product__categor__269AB60B");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Review__3213E83F75FCB48F");

            entity.ToTable("Review");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasMaxLength(500)
                .HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue((byte)0)
                .HasColumnName("is_deleted");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Product).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Review__product___278EDA44");

            entity.HasOne(d => d.User).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Review__user_id__2882FE7D");
        });

        modelBuilder.Entity<SaleEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sale_Eve__3213E83F4D3BA373");

            entity.ToTable("Sale_Event");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("end_time");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue((byte)0)
                .HasColumnName("is_deleted");
            entity.Property(e => e.IsOpen).HasColumnName("is_open");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("start_time");
        });

        modelBuilder.Entity<SaleItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sale_ite__3213E83FBC931BE8");

            entity.ToTable("sale_item");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue((byte)0)
                .HasColumnName("is_deleted");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Event).WithMany(p => p.SaleItems)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK__sale_item__event__297722B6");

            entity.HasOne(d => d.Product).WithMany(p => p.SaleItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__sale_item__produ__2A6B46EF");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3213E83F5B26C85D");

            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(false)
                .HasColumnName("deleted");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasColumnName("email");
            entity.Property(e => e.Fullname)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("fullname");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue((byte)0)
                .HasColumnName("is_deleted");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(64)
                .IsFixedLength()
                .HasColumnName("password_hash");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone_number");
        });

        modelBuilder.Entity<Wishlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Wishlist__3213E83FFE075D75");

            entity.ToTable("Wishlist");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Product).WithMany(p => p.Wishlists)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Wishlist__produc__2B5F6B28");

            entity.HasOne(d => d.User).WithMany(p => p.Wishlists)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Wishlist__user_i__2C538F61");
        });

        OnModelCreatingGeneratedProcedures(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}