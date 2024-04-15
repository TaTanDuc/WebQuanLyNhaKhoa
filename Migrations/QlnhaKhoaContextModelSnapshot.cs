﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebQuanLyNhaKhoa.Data;

#nullable disable

namespace WebQuanLyNhaKhoa.Migrations
{
    [DbContext(typeof(QlnhaKhoaContext))]
    partial class QlnhaKhoaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.BenhNhan", b =>
                {
                    b.Property<string>("IdbenhNhan")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("IDBenhNhan")
                        .IsFixedLength();

                    b.Property<string>("DiaChi")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("Gioi")
                        .HasColumnType("bit");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NamSinh")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .IsFixedLength();

                    b.Property<DateTime?>("NgayKhamDau")
                        .HasColumnType("datetime");

                    b.Property<string>("Sdt")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SDT");

                    b.HasKey("IdbenhNhan")
                        .HasName("PK__BenhNhan__33CC78E4CC508853");

                    b.ToTable("BenhNhan", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.ChanDoan", b =>
                {
                    b.Property<string>("IdchanDoan")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("IDChanDoan")
                        .IsFixedLength();

                    b.Property<string>("TenChanDoan")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IdchanDoan")
                        .HasName("PK__ChanDoan__38CFF322FA1A0FA8");

                    b.ToTable("ChanDoan", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.ChucVu", b =>
                {
                    b.Property<string>("MaCv")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("MaCV")
                        .IsFixedLength();

                    b.Property<string>("TenCv")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("TenCV");

                    b.HasKey("MaCv")
                        .HasName("PK__ChucVu__27258E763FCF67CD");

                    b.ToTable("ChucVu", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.DanhSachKham", b =>
                {
                    b.Property<string>("Idkham")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("IDKham")
                        .IsFixedLength();

                    b.Property<string>("IdbenhNhan")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("IDBenhNhan")
                        .IsFixedLength();

                    b.Property<int?>("MaNv")
                        .HasColumnType("int")
                        .HasColumnName("MaNV");

                    b.Property<DateTime>("NgayKham")
                        .HasColumnType("datetime");

                    b.HasKey("Idkham")
                        .HasName("PK__DanhSach__1AB7B4EBC9C507A4");

                    b.HasIndex("IdbenhNhan");

                    b.HasIndex("MaNv");

                    b.ToTable("DanhSachKham", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.DichVu", b =>
                {
                    b.Property<string>("IddichVu")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("IDDichVu")
                        .IsFixedLength();

                    b.Property<decimal>("DonGia")
                        .HasColumnType("money");

                    b.Property<string>("DonViTinh")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("IdchanDoan")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("IDChanDoan")
                        .IsFixedLength();

                    b.Property<string>("TenDichVu")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IddichVu")
                        .HasName("PK__DichVu__C0C959284DEBAF55");

                    b.HasIndex("IdchanDoan");

                    b.ToTable("DichVu", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.DieuTri", b =>
                {
                    b.Property<int>("IddieuTri")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDDieuTri");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IddieuTri"));

                    b.Property<string>("IddichVu")
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("IDDichVu")
                        .IsFixedLength();

                    b.Property<string>("IddungCu")
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("IDDungCu")
                        .IsFixedLength();

                    b.Property<string>("Idkham")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("IDKham")
                        .IsFixedLength();

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<decimal>("ThanhTien")
                        .HasColumnType("money");

                    b.HasKey("IddieuTri")
                        .HasName("PK__DieuTri__85B3D346B461421D");

                    b.HasIndex("IddichVu");

                    b.HasIndex("IddungCu");

                    b.HasIndex("Idkham");

                    b.ToTable("DieuTri", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.DonThuoc", b =>
                {
                    b.Property<int>("IddonThuoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDDonThuoc");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IddonThuoc"));

                    b.Property<string>("IddungCu")
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("IDDungCu")
                        .IsFixedLength();

                    b.Property<string>("Idkham")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("IDKham")
                        .IsFixedLength();

                    b.Property<DateTime?>("NgayLapDt")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayLapDT");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<decimal>("ThanhGia")
                        .HasColumnType("money");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("money");

                    b.HasKey("IddonThuoc")
                        .HasName("PK__DonThuoc__51DB14E8F508B9A4");

                    b.HasIndex("IddungCu");

                    b.HasIndex("Idkham");

                    b.ToTable("DonThuoc", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.HoaDon", b =>
                {
                    b.Property<int>("IdhoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDHoaDon");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdhoaDon"));

                    b.Property<string>("EmailBn")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("EmailBN");

                    b.Property<int>("IddieuTri")
                        .HasColumnType("int")
                        .HasColumnName("IDDieuTri");

                    b.Property<int>("IddonThuoc")
                        .HasColumnType("int")
                        .HasColumnName("IDDonThuoc");

                    b.Property<string>("Idkham")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("IDKham")
                        .IsFixedLength();

                    b.Property<DateTime>("NgayLap")
                        .HasColumnType("datetime");

                    b.Property<string>("PhuongThucThanhToan")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("TienDieuTri")
                        .HasColumnType("money");

                    b.Property<decimal>("TienThuoc")
                        .HasColumnType("money");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("money");

                    b.HasKey("IdhoaDon")
                        .HasName("PK__HoaDon__5B896F49B2BDCE01");

                    b.HasIndex("IddieuTri");

                    b.HasIndex("IddonThuoc");

                    b.HasIndex("Idkham");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.Kho", b =>
                {
                    b.Property<string>("IddungCu")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("IDDungCu")
                        .IsFixedLength();

                    b.Property<string>("DonViTinh")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("IdsanPham")
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("IDSanPham")
                        .IsFixedLength();

                    b.Property<string>("Loai")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenDungCu")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IddungCu")
                        .HasName("PK__Kho__50E8F160A760D1CB");

                    b.HasIndex("IdsanPham");

                    b.ToTable("Kho", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.LichSuNhapXuat", b =>
                {
                    b.Property<int>("MaLs")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaLS");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLs"));

                    b.Property<decimal>("Don")
                        .HasColumnType("money");

                    b.Property<string>("DonViTinh")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("IddungCu")
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("IDDungCu")
                        .IsFixedLength();

                    b.Property<string>("Loai")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int?>("SoLuongNhapXuat")
                        .HasColumnType("int");

                    b.Property<string>("TenDungCu")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("ThanhTien")
                        .HasColumnType("money");

                    b.HasKey("MaLs")
                        .HasName("PK__LichSuNh__2725C772403A6931");

                    b.HasIndex("IddungCu");

                    b.ToTable("LichSuNhapXuat", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.NhanVien", b =>
                {
                    b.Property<int>("MaNv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaNV");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaNv"));

                    b.Property<string>("Hinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KinhNghiem")
                        .HasColumnType("int");

                    b.Property<string>("MaCv")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .HasColumnName("MaCV")
                        .IsFixedLength();

                    b.Property<string>("Sdt")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("SDT")
                        .IsFixedLength();

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenDangNhap")
                        .IsRequired()
                        .HasMaxLength(22)
                        .IsUnicode(false)
                        .HasColumnType("varchar(22)");

                    b.HasKey("MaNv")
                        .HasName("PK__NhanVien__2725D70AD1CBE617");

                    b.HasIndex("MaCv");

                    b.HasIndex("TenDangNhap");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.TaiKhoan", b =>
                {
                    b.Property<string>("TenDangNhap")
                        .HasMaxLength(22)
                        .IsUnicode(false)
                        .HasColumnType("varchar(22)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("TenDangNhap")
                        .HasName("PK__TaiKhoan__55F68FC18F2DBF18");

                    b.ToTable("TaiKhoan", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.ThiTruong", b =>
                {
                    b.Property<string>("IdsanPham")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("IDSanPham")
                        .IsFixedLength();

                    b.Property<decimal>("DonGia")
                        .HasColumnType("money");

                    b.Property<string>("DonViTinh")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Loai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IdsanPham")
                        .HasName("PK__ThiTruon__9D45E58AF1B538DC");

                    b.ToTable("ThiTruong", (string)null);
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Models.UserVM", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Hinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KinhNghiem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MaCv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaNv")
                        .HasColumnType("int");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDangNhap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
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
                    b.HasOne("WebQuanLyNhaKhoa.Models.UserVM", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebQuanLyNhaKhoa.Models.UserVM", null)
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

                    b.HasOne("WebQuanLyNhaKhoa.Models.UserVM", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebQuanLyNhaKhoa.Models.UserVM", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.DanhSachKham", b =>
                {
                    b.HasOne("WebQuanLyNhaKhoa.Data.BenhNhan", "IdbenhNhanNavigation")
                        .WithMany("DanhSachKhams")
                        .HasForeignKey("IdbenhNhan")
                        .IsRequired()
                        .HasConstraintName("chk_IDBenhNhan_DanhSachKham");

                    b.HasOne("WebQuanLyNhaKhoa.Data.NhanVien", "MaNvNavigation")
                        .WithMany("DanhSachKhams")
                        .HasForeignKey("MaNv")
                        .HasConstraintName("chk_MaNV_DanhSachKham");

                    b.Navigation("IdbenhNhanNavigation");

                    b.Navigation("MaNvNavigation");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.DichVu", b =>
                {
                    b.HasOne("WebQuanLyNhaKhoa.Data.ChanDoan", "IdchanDoanNavigation")
                        .WithMany("DichVus")
                        .HasForeignKey("IdchanDoan")
                        .IsRequired()
                        .HasConstraintName("chk_IDChanDoan_DichVu");

                    b.Navigation("IdchanDoanNavigation");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.DieuTri", b =>
                {
                    b.HasOne("WebQuanLyNhaKhoa.Data.DichVu", "IddichVuNavigation")
                        .WithMany("DieuTris")
                        .HasForeignKey("IddichVu")
                        .IsRequired()
                        .HasConstraintName("chk_IDDichVu_DieuTri");

                    b.HasOne("WebQuanLyNhaKhoa.Data.Kho", "IddungCuNavigation")
                        .WithMany("DieuTris")
                        .HasForeignKey("IddungCu")
                        .IsRequired()
                        .HasConstraintName("chk_IDDungCu_DieuTri");

                    b.HasOne("WebQuanLyNhaKhoa.Data.DanhSachKham", "IdkhamNavigation")
                        .WithMany("DieuTris")
                        .HasForeignKey("Idkham")
                        .IsRequired()
                        .HasConstraintName("chk_IDKham_DieuTri");

                    b.Navigation("IddichVuNavigation");

                    b.Navigation("IddungCuNavigation");

                    b.Navigation("IdkhamNavigation");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.DonThuoc", b =>
                {
                    b.HasOne("WebQuanLyNhaKhoa.Data.Kho", "IddungCuNavigation")
                        .WithMany("DonThuocs")
                        .HasForeignKey("IddungCu")
                        .IsRequired()
                        .HasConstraintName("chk_IDDungCu_DonThuoc");

                    b.HasOne("WebQuanLyNhaKhoa.Data.DanhSachKham", "IdkhamNavigation")
                        .WithMany("DonThuocs")
                        .HasForeignKey("Idkham")
                        .IsRequired()
                        .HasConstraintName("chk_IDKham_DonThuoc");

                    b.Navigation("IddungCuNavigation");

                    b.Navigation("IdkhamNavigation");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.HoaDon", b =>
                {
                    b.HasOne("WebQuanLyNhaKhoa.Data.DieuTri", "IddieuTriNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IddieuTri")
                        .IsRequired()
                        .HasConstraintName("chk_IDDieuTri_HoaDon");

                    b.HasOne("WebQuanLyNhaKhoa.Data.DonThuoc", "IddonThuocNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IddonThuoc")
                        .IsRequired()
                        .HasConstraintName("chk_IDDonThuoc_HoaDon");

                    b.HasOne("WebQuanLyNhaKhoa.Data.DanhSachKham", "IdkhamNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("Idkham")
                        .HasConstraintName("chk_IDKham_HoaDon");

                    b.Navigation("IddieuTriNavigation");

                    b.Navigation("IddonThuocNavigation");

                    b.Navigation("IdkhamNavigation");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.Kho", b =>
                {
                    b.HasOne("WebQuanLyNhaKhoa.Data.ThiTruong", "IdsanPhamNavigation")
                        .WithMany("Khos")
                        .HasForeignKey("IdsanPham")
                        .IsRequired()
                        .HasConstraintName("chk_IDSanPham_Kho");

                    b.Navigation("IdsanPhamNavigation");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.LichSuNhapXuat", b =>
                {
                    b.HasOne("WebQuanLyNhaKhoa.Data.Kho", "IddungCuNavigation")
                        .WithMany("LichSuNhapXuats")
                        .HasForeignKey("IddungCu")
                        .IsRequired()
                        .HasConstraintName("chk_IDDungCu_NK");

                    b.Navigation("IddungCuNavigation");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.NhanVien", b =>
                {
                    b.HasOne("WebQuanLyNhaKhoa.Data.ChucVu", "MaCvNavigation")
                        .WithMany("NhanViens")
                        .HasForeignKey("MaCv")
                        .IsRequired()
                        .HasConstraintName("chk_MaCV");

                    b.HasOne("WebQuanLyNhaKhoa.Data.TaiKhoan", "TenDangNhapNavigation")
                        .WithMany("NhanViens")
                        .HasForeignKey("TenDangNhap")
                        .IsRequired()
                        .HasConstraintName("chk_TenDangNhap");

                    b.Navigation("MaCvNavigation");

                    b.Navigation("TenDangNhapNavigation");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.BenhNhan", b =>
                {
                    b.Navigation("DanhSachKhams");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.ChanDoan", b =>
                {
                    b.Navigation("DichVus");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.DanhSachKham", b =>
                {
                    b.Navigation("DieuTris");

                    b.Navigation("DonThuocs");

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.DichVu", b =>
                {
                    b.Navigation("DieuTris");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.DieuTri", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.DonThuoc", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.Kho", b =>
                {
                    b.Navigation("DieuTris");

                    b.Navigation("DonThuocs");

                    b.Navigation("LichSuNhapXuats");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.NhanVien", b =>
                {
                    b.Navigation("DanhSachKhams");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.TaiKhoan", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("WebQuanLyNhaKhoa.Data.ThiTruong", b =>
                {
                    b.Navigation("Khos");
                });
#pragma warning restore 612, 618
        }
    }
}
