﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Senparc.Service;

namespace Senparc.Service.Migrations.Migrations.SQLite
{
    [DbContext(typeof(SystemServiceEntities))]
    [Migration("20210105114738_AddTelantId")]
    partial class AddTelantId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("Senparc.Core.Models.AdminUserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<bool>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastLoginIp")
                        .HasColumnName("LastLoginIP")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime>("LastLoginTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("RealName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<int>("TenantId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ThisLoginIp")
                        .HasColumnName("ThisLoginIP")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime>("ThisLoginTime")
                        .HasColumnType("datetime");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("AdminUserInfos");
                });

            modelBuilder.Entity("Senparc.Core.Models.FeedBack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<int>("TenantId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("FeedBacks");
                });

            modelBuilder.Entity("Senparc.Ncf.Core.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("District")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("EmailChecked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Flag")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("HeadImgUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastLoginIP")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastLoginTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastWeixinSignInTime")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("LockMoney")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Locked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Package")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<bool?>("PhoneChecked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PicUrl")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<decimal>("Points")
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("QQ")
                        .HasColumnType("TEXT");

                    b.Property<string>("RealName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<byte>("Sex")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TenantId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ThisLoginIp")
                        .HasColumnName("ThisLoginIP")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<DateTime>("ThisLoginTime")
                        .HasColumnType("datetime");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("WeixinOpenId")
                        .HasColumnType("TEXT");

                    b.Property<int>("WeixinSignTimes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WeixinUnionId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Senparc.Ncf.Core.Models.AccountPayLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddIp")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<DateTime>("CompleteTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<bool>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("GetPoints")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("OrderType")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PayMoney")
                        .HasColumnType("TEXT");

                    b.Property<string>("PayParam")
                        .HasColumnType("TEXT");

                    b.Property<int>("PayType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PrepayId")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<byte>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TenantId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("TradeNumber")
                        .HasColumnType("varchar(150)");

                    b.Property<byte?>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("UsedPoints")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("AccountPayLogs");
                });

            modelBuilder.Entity("Senparc.Ncf.Core.Models.DataBaseModel.SysButton", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<string>("ButtonName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<bool>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("MenuId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("OpearMark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<int>("TenantId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT")
                        .HasMaxLength(350);

                    b.HasKey("Id");

                    b.ToTable("SysButtons");
                });

            modelBuilder.Entity("Senparc.Ncf.Core.Models.DataBaseModel.SysMenu", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<bool>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("MenuName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(150);

                    b.Property<int>("MenuType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ParentId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<string>("ResourceCode")
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<int>("Sort")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TenantId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT")
                        .HasMaxLength(350);

                    b.Property<bool>("Visible")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SysMenus");
                });

            modelBuilder.Entity("Senparc.Ncf.Core.Models.DataBaseModel.SysPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<bool>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMenu")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("PermissionId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<string>("ResourceCode")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("RoleCode")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("TenantId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SysPermission");
                });

            modelBuilder.Entity("Senparc.Ncf.Core.Models.DataBaseModel.SysRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<bool>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<string>("RoleCode")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("RoleName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("TenantId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SysRoles");
                });

            modelBuilder.Entity("Senparc.Ncf.Core.Models.DataBaseModel.SysRoleAdminUserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<bool>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<string>("RoleCode")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("TenantId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SysRoleAdminUserInfos");
                });

            modelBuilder.Entity("Senparc.Ncf.Core.Models.DataBaseModel.XncfModule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("datetime");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<bool>("AllowRemove")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("MenuId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("MenuName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<int>("State")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TenantId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("UpdateLog")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("XncfModules");
                });

            modelBuilder.Entity("Senparc.Ncf.Core.Models.PointsLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AccountPayLogId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<decimal>("AfterPoints")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("BeforePoints")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Points")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<int>("TenantId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("AccountPayLogId");

                    b.ToTable("PointsLogs");
                });

            modelBuilder.Entity("Senparc.Ncf.Core.Models.SystemConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<bool>("Flag")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("HideModuleManager")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("MchId")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("MchKey")
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(300);

                    b.Property<string>("SystemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenPayAppId")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("TenantId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SystemConfigs");
                });

            modelBuilder.Entity("Senparc.Core.Models.FeedBack", b =>
                {
                    b.HasOne("Senparc.Ncf.Core.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Senparc.Ncf.Core.Models.AccountPayLog", b =>
                {
                    b.HasOne("Senparc.Ncf.Core.Models.Account", "Account")
                        .WithMany("AccountPayLogs")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Senparc.Ncf.Core.Models.PointsLog", b =>
                {
                    b.HasOne("Senparc.Ncf.Core.Models.Account", "Account")
                        .WithMany("PointsLogs")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Senparc.Ncf.Core.Models.AccountPayLog", "AccountPayLog")
                        .WithMany("PointsLogs")
                        .HasForeignKey("AccountPayLogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}