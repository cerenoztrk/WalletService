using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WalletService.Models;

public partial class WalletContext : DbContext
{
    public WalletContext()
    {
    }

    public WalletContext(DbContextOptions<WalletContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<VUser> VUsers { get; set; }

    public virtual DbSet<UserDebit> UserDebits { get; set; }
    public virtual DbSet<VUserDebit> VUserDebits { get; set; }

    public virtual DbSet<UserInvoice> UserInvoices { get; set; }
    public virtual DbSet<VUserInvoice> VUserInvoices { get; set; }

    public virtual DbSet<UserWallet> UserWallets { get; set; }
   

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Wallet;User Id=sa; Password=1234;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VUserInvoice>(entity =>
        {
            entity.ToView("VUserInvoice");
            entity.HasNoKey();


        });
        modelBuilder.Entity<VUser>(entity =>
        {
            entity.ToView("VUser");
            entity.HasNoKey();


        });

        modelBuilder.Entity<VUserDebit>(entity =>
        {
            entity.ToView("VUserDebit");
            entity.HasNoKey();


        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserDebit>(entity =>
        {
            entity.HasKey(e => e.DebitsId);

            entity.ToTable("user_debits");

            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DebtAmount).HasColumnType("money");
        });

        modelBuilder.Entity<UserInvoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId);

            entity.ToTable("user_invoices");

            entity.Property(e => e.InvoiceName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalInvoice).HasColumnType("money");
        });

        modelBuilder.Entity<UserWallet>(entity =>
        {
            entity.HasKey(e => e.BalanceId);

            entity.ToTable("user_wallets");

            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.Bank)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
