﻿// <auto-generated />
using System;
using BTCPayServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BTCPayServer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("BTCPayServer.Data.APIKeyData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Blob")
                        .HasColumnType("BLOB");

                    b.Property<string>("Label")
                        .HasColumnType("TEXT");

                    b.Property<string>("StoreId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.HasIndex("UserId");

                    b.ToTable("ApiKeys");
                });

            modelBuilder.Entity("BTCPayServer.Data.AddressInvoiceData", b =>
                {
                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("InvoiceDataId")
                        .HasColumnType("TEXT");

                    b.HasKey("Address");

                    b.HasIndex("InvoiceDataId");

                    b.ToTable("AddressInvoices");
                });

            modelBuilder.Entity("BTCPayServer.Data.AppData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AppType")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Settings")
                        .HasColumnType("TEXT");

                    b.Property<string>("StoreDataId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TagAllInvoices")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StoreDataId");

                    b.ToTable("Apps");
                });

            modelBuilder.Entity("BTCPayServer.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RequiresEmailConfirmation")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BTCPayServer.Data.HistoricalAddressInvoiceData", b =>
                {
                    b.Property<string>("InvoiceDataId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Assigned")
                        .HasColumnType("TEXT");

                    b.Property<string>("CryptoCode")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("UnAssigned")
                        .HasColumnType("TEXT");

                    b.HasKey("InvoiceDataId", "Address");

                    b.ToTable("HistoricalAddressInvoices");
                });

            modelBuilder.Entity("BTCPayServer.Data.InvoiceData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Archived")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Blob")
                        .HasColumnType("BLOB");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentRefundId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExceptionStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("StoreDataId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StoreDataId");

                    b.HasIndex("Id", "CurrentRefundId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("BTCPayServer.Data.InvoiceEventData", b =>
                {
                    b.Property<string>("InvoiceDataId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UniqueId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<int>("Severity")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("TEXT");

                    b.HasKey("InvoiceDataId", "UniqueId");

                    b.ToTable("InvoiceEvents");
                });

            modelBuilder.Entity("BTCPayServer.Data.NotificationData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasMaxLength(36);

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Blob")
                        .HasColumnType("BLOB");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("NotificationType")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<bool>("Seen")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("BTCPayServer.Data.OffchainTransactionData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasMaxLength(64);

                    b.Property<byte[]>("Blob")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("OffchainTransactions");
                });

            modelBuilder.Entity("BTCPayServer.Data.PairedSINData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Label")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("PairingTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("SIN")
                        .HasColumnType("TEXT");

                    b.Property<string>("StoreDataId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SIN");

                    b.HasIndex("StoreDataId");

                    b.ToTable("PairedSINData");
                });

            modelBuilder.Entity("BTCPayServer.Data.PairingCodeData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Expiration")
                        .HasColumnType("TEXT");

                    b.Property<string>("Facade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Label")
                        .HasColumnType("TEXT");

                    b.Property<string>("SIN")
                        .HasColumnType("TEXT");

                    b.Property<string>("StoreDataId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TokenValue")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PairingCodes");
                });

            modelBuilder.Entity("BTCPayServer.Data.PayjoinLock", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("PayjoinLocks");
                });

            modelBuilder.Entity("BTCPayServer.Data.PaymentData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Accounted")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Blob")
                        .HasColumnType("BLOB");

                    b.Property<string>("InvoiceDataId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceDataId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BTCPayServer.Data.PaymentRequestData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Archived")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Blob")
                        .HasColumnType("BLOB");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTimeOffset(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StoreDataId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Status");

                    b.HasIndex("StoreDataId");

                    b.ToTable("PaymentRequests");
                });

            modelBuilder.Entity("BTCPayServer.Data.PayoutData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<byte[]>("Blob")
                        .HasColumnType("BLOB");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Destination")
                        .HasColumnType("TEXT");

                    b.Property<string>("PaymentMethodId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<byte[]>("Proof")
                        .HasColumnType("BLOB");

                    b.Property<string>("PullPaymentDataId")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("Destination")
                        .IsUnique();

                    b.HasIndex("PullPaymentDataId");

                    b.HasIndex("State");

                    b.ToTable("Payouts");
                });

            modelBuilder.Entity("BTCPayServer.Data.PendingInvoiceData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PendingInvoices");
                });

            modelBuilder.Entity("BTCPayServer.Data.PlannedTransaction", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<byte[]>("Blob")
                        .HasColumnType("BLOB");

                    b.Property<DateTimeOffset>("BroadcastAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PlannedTransactions");
                });

            modelBuilder.Entity("BTCPayServer.Data.PullPaymentData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<bool>("Archived")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Blob")
                        .HasColumnType("BLOB");

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<long?>("Period")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("StoreId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("PullPayments");
                });

            modelBuilder.Entity("BTCPayServer.Data.RefundData", b =>
                {
                    b.Property<string>("InvoiceDataId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PullPaymentDataId")
                        .HasColumnType("TEXT");

                    b.HasKey("InvoiceDataId", "PullPaymentDataId");

                    b.HasIndex("PullPaymentDataId");

                    b.ToTable("Refunds");
                });

            modelBuilder.Entity("BTCPayServer.Data.SettingData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("BTCPayServer.Data.StoreData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefaultCrypto")
                        .HasColumnType("TEXT");

                    b.Property<string>("DerivationStrategies")
                        .HasColumnType("TEXT");

                    b.Property<string>("DerivationStrategy")
                        .HasColumnType("TEXT");

                    b.Property<int>("SpeedPolicy")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("StoreBlob")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("StoreCertificate")
                        .HasColumnType("BLOB");

                    b.Property<string>("StoreName")
                        .HasColumnType("TEXT");

                    b.Property<string>("StoreWebsite")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("BTCPayServer.Data.StoredFile", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("StorageFileName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("BTCPayServer.Data.U2FDevice", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("AttestationCert")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("Counter")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("KeyHandle")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PublicKey")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("U2FDevices");
                });

            modelBuilder.Entity("BTCPayServer.Data.UserStore", b =>
                {
                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("StoreDataId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.HasKey("ApplicationUserId", "StoreDataId");

                    b.HasIndex("StoreDataId");

                    b.ToTable("UserStore");
                });

            modelBuilder.Entity("BTCPayServer.Data.WalletData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Blob")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("BTCPayServer.Data.WalletTransactionData", b =>
                {
                    b.Property<string>("WalletDataId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TransactionId")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Blob")
                        .HasColumnType("BLOB");

                    b.Property<string>("Labels")
                        .HasColumnType("TEXT");

                    b.HasKey("WalletDataId", "TransactionId");

                    b.ToTable("WalletTransactions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BTCPayServer.Data.APIKeyData", b =>
                {
                    b.HasOne("BTCPayServer.Data.StoreData", "StoreData")
                        .WithMany("APIKeys")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTCPayServer.Data.ApplicationUser", "User")
                        .WithMany("APIKeys")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTCPayServer.Data.AddressInvoiceData", b =>
                {
                    b.HasOne("BTCPayServer.Data.InvoiceData", "InvoiceData")
                        .WithMany("AddressInvoices")
                        .HasForeignKey("InvoiceDataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTCPayServer.Data.AppData", b =>
                {
                    b.HasOne("BTCPayServer.Data.StoreData", "StoreData")
                        .WithMany("Apps")
                        .HasForeignKey("StoreDataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTCPayServer.Data.HistoricalAddressInvoiceData", b =>
                {
                    b.HasOne("BTCPayServer.Data.InvoiceData", "InvoiceData")
                        .WithMany("HistoricalAddressInvoices")
                        .HasForeignKey("InvoiceDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BTCPayServer.Data.InvoiceData", b =>
                {
                    b.HasOne("BTCPayServer.Data.StoreData", "StoreData")
                        .WithMany("Invoices")
                        .HasForeignKey("StoreDataId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTCPayServer.Data.RefundData", "CurrentRefund")
                        .WithMany()
                        .HasForeignKey("Id", "CurrentRefundId");
                });

            modelBuilder.Entity("BTCPayServer.Data.InvoiceEventData", b =>
                {
                    b.HasOne("BTCPayServer.Data.InvoiceData", "InvoiceData")
                        .WithMany("Events")
                        .HasForeignKey("InvoiceDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BTCPayServer.Data.NotificationData", b =>
                {
                    b.HasOne("BTCPayServer.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("Notifications")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BTCPayServer.Data.PairedSINData", b =>
                {
                    b.HasOne("BTCPayServer.Data.StoreData", "StoreData")
                        .WithMany("PairedSINs")
                        .HasForeignKey("StoreDataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTCPayServer.Data.PaymentData", b =>
                {
                    b.HasOne("BTCPayServer.Data.InvoiceData", "InvoiceData")
                        .WithMany("Payments")
                        .HasForeignKey("InvoiceDataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTCPayServer.Data.PaymentRequestData", b =>
                {
                    b.HasOne("BTCPayServer.Data.StoreData", "StoreData")
                        .WithMany("PaymentRequests")
                        .HasForeignKey("StoreDataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTCPayServer.Data.PayoutData", b =>
                {
                    b.HasOne("BTCPayServer.Data.PullPaymentData", "PullPaymentData")
                        .WithMany("Payouts")
                        .HasForeignKey("PullPaymentDataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTCPayServer.Data.PendingInvoiceData", b =>
                {
                    b.HasOne("BTCPayServer.Data.InvoiceData", "InvoiceData")
                        .WithMany("PendingInvoices")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BTCPayServer.Data.PullPaymentData", b =>
                {
                    b.HasOne("BTCPayServer.Data.StoreData", "StoreData")
                        .WithMany("PullPayments")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTCPayServer.Data.RefundData", b =>
                {
                    b.HasOne("BTCPayServer.Data.InvoiceData", "InvoiceData")
                        .WithMany("Refunds")
                        .HasForeignKey("InvoiceDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BTCPayServer.Data.PullPaymentData", "PullPaymentData")
                        .WithMany()
                        .HasForeignKey("PullPaymentDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BTCPayServer.Data.StoredFile", b =>
                {
                    b.HasOne("BTCPayServer.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("StoredFiles")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("BTCPayServer.Data.U2FDevice", b =>
                {
                    b.HasOne("BTCPayServer.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("U2FDevices")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("BTCPayServer.Data.UserStore", b =>
                {
                    b.HasOne("BTCPayServer.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("UserStores")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BTCPayServer.Data.StoreData", "StoreData")
                        .WithMany("UserStores")
                        .HasForeignKey("StoreDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BTCPayServer.Data.WalletTransactionData", b =>
                {
                    b.HasOne("BTCPayServer.Data.WalletData", "WalletData")
                        .WithMany("WalletTransactions")
                        .HasForeignKey("WalletDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BTCPayServer.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BTCPayServer.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BTCPayServer.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BTCPayServer.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
