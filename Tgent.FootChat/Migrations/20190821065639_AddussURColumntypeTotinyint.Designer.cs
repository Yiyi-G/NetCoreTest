﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tgnet.FootChat.Data;

namespace Tgnet.FootChat.Migrations
{
    [DbContext(typeof(FootChatContext))]
    [Migration("20190821065639_AddussURColumntypeTotinyint")]
    partial class AddussURColumntypeTotinyint
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tgnet.FootChat.Data.AddressBookMobile", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("attentionDate")
                        .HasColumnType("datetime");

                    b.Property<string>("company")
                        .HasMaxLength(100);

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("haveRecommended");

                    b.Property<bool>("isAttention");

                    b.Property<string>("mobile")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("name")
                        .HasMaxLength(50);

                    b.Property<long?>("tguid");

                    b.Property<byte[]>("timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("uid");

                    b.HasKey("id");

                    b.ToTable("AddressBookMobile");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.AssociatedProjRecord", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime");

                    b.Property<long>("fid");

                    b.Property<long>("newProjId");

                    b.Property<long>("oldProjId");

                    b.Property<long>("operator");

                    b.HasKey("id");

                    b.ToTable("AssociatedProjRecord");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.AttentionStatistics", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("attentionCount");

                    b.Property<int>("attentionUserCount");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime");

                    b.Property<int>("invitationCount");

                    b.Property<decimal>("successRate")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("todayAttentionCount");

                    b.Property<int>("todayAttentionUserCount");

                    b.Property<int>("todayInvitationCount");

                    b.HasKey("id");

                    b.ToTable("AttentionStatistics");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.CallRecord", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("caller");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime");

                    b.Property<long>("receiver");

                    b.HasKey("id");

                    b.ToTable("CallRecord");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.Class", b =>
                {
                    b.Property<long>("classId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("isEnable");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("property")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime");

                    b.Property<byte>("type")
                        .HasColumnType("tinyint");

                    b.HasKey("classId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.ClassStuRelation", b =>
                {
                    b.Property<long>("rid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("classId");

                    b.Property<byte?>("committeeType")
                        .HasColumnType("tinyint");

                    b.Property<byte>("payState")
                        .HasColumnType("tinyint");

                    b.Property<long>("uid");

                    b.HasKey("rid")
                        .HasName("PK__ClassStu__C2B7EDE869FBBC1F");

                    b.ToTable("ClassStuRelation");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.DockedRecord", b =>
                {
                    b.Property<long>("rid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime");

                    b.Property<long>("fid");

                    b.Property<string>("message")
                        .HasMaxLength(300);

                    b.Property<long>("receiver");

                    b.Property<long>("sender");

                    b.Property<byte>("status")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime");

                    b.HasKey("rid");

                    b.ToTable("DockedRecord");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.DockedStatistics", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("agreedDockedTotalNum");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime");

                    b.Property<int>("dockedTotalNum");

                    b.Property<int>("todayAgreedDockedNum");

                    b.Property<int>("todayDockedNum");

                    b.Property<int>("todayRejectedDockedNum");

                    b.Property<int>("todaySuccessfulDockedNum");

                    b.HasKey("id");

                    b.ToTable("DockedStatistics");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.FootCharUserServiceState", b =>
                {
                    b.Property<long>("uid");

                    b.Property<DateTime>("expired")
                        .HasColumnType("datetime");

                    b.Property<byte>("level")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime");

                    b.HasKey("uid");

                    b.ToTable("UserServiceState");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.FootPrint", b =>
                {
                    b.Property<long>("fid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasMaxLength(200);

                    b.Property<string>("areaNo")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(50);

                    b.Property<string>("content")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime");

                    b.Property<string>("examinRemarks")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("examineDate")
                        .HasColumnType("datetime");

                    b.Property<long?>("examiner");

                    b.Property<bool>("isEnable")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("isVerifiedLocked");

                    b.Property<double?>("latitude");

                    b.Property<double?>("longitude");

                    b.Property<DateTime>("orderUpdated")
                        .HasColumnName("orderUpdated")
                        .HasColumnType("datetime");

                    b.Property<long>("pid");

                    b.Property<byte>("state")
                        .HasColumnType("tinyint");

                    b.Property<long>("tgFid");

                    b.Property<long?>("transferOperator");

                    b.Property<byte>("transferScales")
                        .HasColumnType("tinyint");

                    b.Property<byte>("transferState");

                    b.Property<DateTime?>("transferUpdated")
                        .HasColumnType("datetime");

                    b.Property<long>("uid");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("verifiedlockDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("fid");

                    b.HasIndex("pid", "orderUpdated")
                        .HasName("IX_FootPrint");

                    b.ToTable("FootPrint");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.FootPrintImg", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("comfirmDate")
                        .HasColumnType("datetime");

                    b.Property<long?>("comfirmer");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime");

                    b.Property<long>("fid");

                    b.Property<string>("imageKey")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<bool>("isComfirm");

                    b.Property<bool>("isEnabled")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.Property<double?>("latitude");

                    b.Property<double?>("longitude");

                    b.Property<int?>("order");

                    b.Property<DateTime?>("photoTime")
                        .HasColumnType("datetime");

                    b.HasKey("id");

                    b.ToTable("FootPrintImg");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.FootPrintStatistics", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("creatorCount");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime");

                    b.Property<int>("fpViewCount");

                    b.Property<int>("gt2FollowProjNum");

                    b.Property<int>("gt2FollowUserNum");

                    b.Property<int>("todayCreatorCount");

                    b.Property<int>("todayPassFootPrintCount");

                    b.Property<int>("todayUnPassFootPrintCount");

                    b.Property<int>("totalCount");

                    b.Property<int>("totalPassFootPrintCount");

                    b.Property<int>("totalViewUserCount");

                    b.HasKey("id");

                    b.ToTable("FootPrintStatistics");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.FootPrintTag", b =>
                {
                    b.Property<long>("fid");

                    b.Property<long>("tid");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime");

                    b.HasKey("fid", "tid");

                    b.ToTable("FootPrintTag");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.FootUser", b =>
                {
                    b.Property<long>("uid");

                    b.Property<string>("areaNo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("company")
                        .HasMaxLength(100);

                    b.Property<string>("cover")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(200);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime");

                    b.Property<bool>("isInner");

                    b.Property<bool>("isLocked");

                    b.Property<bool>("isNeedVerify");

                    b.Property<bool>("isVerifiedLocked");

                    b.Property<string>("job")
                        .HasMaxLength(30);

                    b.Property<DateTime>("lastLogin")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("lockDate")
                        .HasColumnType("datetime");

                    b.Property<long?>("lockOperator");

                    b.Property<string>("lockReason")
                        .HasMaxLength(200);

                    b.Property<int>("loginCount");

                    b.Property<string>("mobile")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("name")
                        .HasMaxLength(30);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<byte?>("sex")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("submiVerifytDate")
                        .HasColumnType("datetime");

                    b.Property<string>("userFacePah")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("userFacePathSmall")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<DateTime?>("verifiedlockDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("verifyDate")
                        .HasColumnType("datetime");

                    b.Property<string>("verifyFailReason")
                        .HasMaxLength(200);

                    b.Property<string>("verifyImage")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<byte>("verifyStatus")
                        .HasColumnType("tinyint");

                    b.Property<long?>("verifyUser");

                    b.HasKey("uid");

                    b.HasIndex("mobile")
                        .IsUnique()
                        .HasName("IX_FootUser");

                    b.ToTable("FootUser");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.ImportFootPrintRecord", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("fid");

                    b.Property<bool>("isSuccess");

                    b.Property<long>("tgFid");

                    b.Property<long>("uid");

                    b.Property<string>("unSuccessReason")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("id");

                    b.ToTable("ImportFootPrintRecord");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.ImportUserRecord", b =>
                {
                    b.Property<long>("uid");

                    b.Property<DateTime>("importTime")
                        .HasColumnType("datetime");

                    b.HasKey("uid");

                    b.ToTable("ImportUserRecord");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.InstitudeOfGrowthTrade", b =>
                {
                    b.Property<string>("tradeNo")
                        .HasMaxLength(50);

                    b.Property<bool>("buySuccess");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime");

                    b.Property<string>("extension")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<bool>("isDelete");

                    b.Property<bool>("isPaied");

                    b.Property<byte>("pType")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("paied")
                        .HasColumnType("datetime");

                    b.Property<byte>("payment")
                        .HasColumnType("tinyint");

                    b.Property<long?>("seller");

                    b.Property<DateTime?>("successed")
                        .HasColumnType("datetime");

                    b.Property<decimal>("total")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<byte>("type")
                        .HasColumnType("tinyint");

                    b.Property<long>("uid");

                    b.HasKey("tradeNo");

                    b.ToTable("InstitudeOfGrowthTrade");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.InteractionStatistics", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("callTotalNum");

                    b.Property<int>("callUserNum");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime");

                    b.Property<int>("todayCallTotalNum");

                    b.Property<int>("todayVipCallUserNum");

                    b.Property<int>("vipCallTotalNum");

                    b.Property<int>("vipCallUserNum");

                    b.Property<int>("vipTodayCallTotalNum");

                    b.HasKey("id");

                    b.ToTable("InteractionStatistics");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.MobileInfo", b =>
                {
                    b.Property<long>("uid");

                    b.Property<string>("deviceId")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("clientVersion")
                        .HasMaxLength(50);

                    b.Property<string>("ip")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("os")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("resolution")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("trademark")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime");

                    b.HasKey("uid", "deviceId");

                    b.ToTable("MobileInfo");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.Relation", b =>
                {
                    b.Property<long>("sender");

                    b.Property<long>("receiver");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime");

                    b.Property<long>("dateVersion");

                    b.Property<string>("description")
                        .HasMaxLength(150);

                    b.Property<byte>("from");

                    b.Property<bool>("inReceiverBlack");

                    b.Property<bool>("inSenderBlack");

                    b.Property<bool>("inSession");

                    b.Property<bool>("isNotNotiry");

                    b.Property<bool>("isStar");

                    b.Property<string>("message")
                        .HasMaxLength(200);

                    b.Property<byte>("rType")
                        .HasColumnType("tinyint");

                    b.Property<string>("remark")
                        .HasMaxLength(20);

                    b.Property<bool>("sessionTop");

                    b.Property<DateTime>("updateDate")
                        .HasColumnType("datetime");

                    b.HasKey("sender", "receiver");

                    b.ToTable("Relation");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.Student", b =>
                {
                    b.Property<long>("uid");

                    b.Property<string>("bussinessAreas")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("buyDate")
                        .HasColumnType("datetime");

                    b.Property<string>("company")
                        .HasMaxLength(50);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime");

                    b.Property<bool>("isBuy");

                    b.Property<string>("job")
                        .HasMaxLength(20);

                    b.Property<double?>("lastYearAchievement");

                    b.Property<string>("name")
                        .HasMaxLength(10);

                    b.Property<string>("necessaryDoType")
                        .HasMaxLength(50);

                    b.Property<string>("needCooperateProduct")
                        .HasMaxLength(200);

                    b.Property<string>("needCustomSource")
                        .HasMaxLength(200);

                    b.Property<string>("products")
                        .HasMaxLength(200);

                    b.Property<byte?>("sex")
                        .HasColumnType("tinyint");

                    b.Property<string>("stageNos")
                        .HasMaxLength(200);

                    b.Property<double?>("thisYearGoal");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime");

                    b.Property<string>("weChat")
                        .HasMaxLength(50);

                    b.Property<int?>("yearOfWorking");

                    b.HasKey("uid");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.SuggestFeedback", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<long>("uid");

                    b.HasKey("id");

                    b.ToTable("SuggestFeedback");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.TagSource", b =>
                {
                    b.Property<long>("tid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime");

                    b.Property<long>("gid");

                    b.Property<bool>("isEnable");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<long>("operator");

                    b.Property<int>("order");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime");

                    b.HasKey("tid");

                    b.ToTable("TagSource");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.TouristViewFootPrintRecord", b =>
                {
                    b.Property<string>("devieceId")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<long>("fid");

                    b.Property<int>("count");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime");

                    b.HasKey("devieceId", "fid");

                    b.ToTable("TouristViewFootPrintRecord");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.Trade", b =>
                {
                    b.Property<string>("tradeNo")
                        .HasMaxLength(50);

                    b.Property<bool>("buySuccess");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime");

                    b.Property<string>("extension")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<bool>("isDelete");

                    b.Property<bool>("isPaied");

                    b.Property<DateTime?>("paied")
                        .HasColumnType("datetime");

                    b.Property<byte>("payment")
                        .HasColumnType("tinyint");

                    b.Property<long?>("seller");

                    b.Property<DateTime?>("successed")
                        .HasColumnType("datetime");

                    b.Property<decimal>("total")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<byte>("type")
                        .HasColumnType("tinyint");

                    b.Property<long>("uid");

                    b.HasKey("tradeNo");

                    b.ToTable("Trade");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.UserBrand", b =>
                {
                    b.Property<long>("bid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long>("uid");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime");

                    b.HasKey("bid");

                    b.ToTable("UserBrand");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.UserBusinessArea", b =>
                {
                    b.Property<long>("uid");

                    b.Property<string>("areaNo")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime");

                    b.HasKey("uid", "areaNo");

                    b.ToTable("UserBusinessArea");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.UserComplain", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime");

                    b.Property<byte>("kind")
                        .HasColumnType("tinyint");

                    b.Property<long>("uid");

                    b.HasKey("id");

                    b.ToTable("UserComplain");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.UserFavorite", b =>
                {
                    b.Property<long>("uid");

                    b.Property<long>("pid");

                    b.Property<DateTime>("Updated");

                    b.Property<bool>("isEnabled")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.HasKey("uid", "pid");

                    b.ToTable("UserFavorite");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.UserLoginRecord", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ip")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("loginTime")
                        .HasColumnType("datetime");

                    b.Property<long>("uid");

                    b.HasKey("id");

                    b.ToTable("UserLoginRecord");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.UserProduct", b =>
                {
                    b.Property<long>("pid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long>("uid");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime");

                    b.HasKey("pid");

                    b.ToTable("UserProduct");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.UserServiceStateUpdateRecord", b =>
                {
                    b.Property<long>("rid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IncreaseDays");

                    b.Property<DateTime>("creted")
                        .HasColumnType("datetime");

                    b.Property<string>("remark")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<byte>("type")
                        .HasColumnType("tinyint");

                    b.Property<long>("uid");

                    b.HasKey("rid");

                    b.ToTable("UserServiceStateUpdateRecord");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.UserSetting", b =>
                {
                    b.Property<long>("uid");

                    b.Property<bool>("isOpenNightQuiet");

                    b.Property<bool>("isOpenShake");

                    b.Property<bool>("isOpenVoice");

                    b.Property<bool>("isPushNotify");

                    b.Property<DateTime>("settingTime")
                        .HasColumnType("datetime");

                    b.HasKey("uid");

                    b.ToTable("UserSetting");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.UserStatistics", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime");

                    b.Property<int>("officialUserCount");

                    b.Property<decimal>("paidRate")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<int>("todayCreatedCount");

                    b.Property<int>("todayPaidUserCount");

                    b.Property<int>("todayPassCount");

                    b.Property<int>("todayUnPassCount");

                    b.Property<int>("totalCount");

                    b.Property<int>("trailUserCount");

                    b.Property<int>("verifiedCount");

                    b.HasKey("id");

                    b.ToTable("UserStatistics");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.UserViewFootPrintRecord", b =>
                {
                    b.Property<long>("uid");

                    b.Property<long>("fid");

                    b.Property<int>("count");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime");

                    b.HasKey("uid", "fid");

                    b.ToTable("UserViewFootPrintRecord");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.UserViewProjFootListRecord", b =>
                {
                    b.Property<long>("uid");

                    b.Property<long>("pid");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime");

                    b.HasKey("uid", "pid");

                    b.ToTable("UserViewProjFootListRecord");
                });

            modelBuilder.Entity("Tgnet.FootChat.Data.UserViewProjRecord", b =>
                {
                    b.Property<long>("pid");

                    b.Property<long>("uid");

                    b.Property<int>("count");

                    b.Property<DateTime>("updated")
                        .HasColumnType("datetime");

                    b.HasKey("pid", "uid")
                        .HasName("PK_UserViewProjRecord_1");

                    b.ToTable("UserViewProjRecord");
                });
#pragma warning restore 612, 618
        }
    }
}
