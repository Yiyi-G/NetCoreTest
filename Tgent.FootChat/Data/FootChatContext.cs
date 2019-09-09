using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Tgnet.FootChat.Data;

namespace Tgnet.FootChat.Data
{
    public partial class FootChatContext : DbContext
    {
        public FootChatContext()
        {
        }

        public FootChatContext(DbContextOptions<FootChatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddressBookMobile> AddressBookMobile { get; set; }
        public virtual DbSet<AssociatedProjRecord> AssociatedProjRecord { get; set; }
        public virtual DbSet<AttentionStatistics> AttentionStatistics { get; set; }
        public virtual DbSet<CallRecord> CallRecord { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<ClassStuRelation> ClassStuRelation { get; set; }
        public virtual DbSet<DockedRecord> DockedRecord { get; set; }
        public virtual DbSet<DockedStatistics> DockedStatistics { get; set; }
        public virtual DbSet<FootPrint> FootPrint { get; set; }
        public virtual DbSet<FootPrintImg> FootPrintImg { get; set; }
        public virtual DbSet<FootPrintStatistics> FootPrintStatistics { get; set; }
        public virtual DbSet<FootPrintTag> FootPrintTag { get; set; }
        public virtual DbSet<FootUser> FootUser { get; set; }
        public virtual DbSet<ImportFootPrintRecord> ImportFootPrintRecord { get; set; }
        public virtual DbSet<ImportUserRecord> ImportUserRecord { get; set; }
        public virtual DbSet<InstitudeOfGrowthTrade> InstitudeOfGrowthTrade { get; set; }
        public virtual DbSet<InteractionStatistics> InteractionStatistics { get; set; }
        public virtual DbSet<MobileInfo> MobileInfo { get; set; }
        public virtual DbSet<Relation> Relation { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<SuggestFeedback> SuggestFeedback { get; set; }
        public virtual DbSet<TagSource> TagSource { get; set; }
        public virtual DbSet<TouristViewFootPrintRecord> TouristViewFootPrintRecord { get; set; }
        public virtual DbSet<Trade> Trade { get; set; }
        public virtual DbSet<UserBrand> UserBrand { get; set; }
        public virtual DbSet<UserBusinessArea> UserBusinessArea { get; set; }
        public virtual DbSet<UserComplain> UserComplain { get; set; }
        public virtual DbSet<UserFavorite> UserFavorite { get; set; }
        public virtual DbSet<UserLoginRecord> UserLoginRecord { get; set; }
        public virtual DbSet<UserProduct> UserProduct { get; set; }
        public virtual DbSet<FootCharUserServiceState> UserServiceState { get; set; }
        public virtual DbSet<UserServiceStateUpdateRecord> UserServiceStateUpdateRecord { get; set; }
        public virtual DbSet<UserSetting> UserSetting { get; set; }
        public virtual DbSet<UserStatistics> UserStatistics { get; set; }
        public virtual DbSet<UserViewFootPrintRecord> UserViewFootPrintRecord { get; set; }
        public virtual DbSet<UserViewProjFootListRecord> UserViewProjFootListRecord { get; set; }
        public virtual DbSet<UserViewProjRecord> UserViewProjRecord { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial CataLog=FootChat;User ID=sa;Password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AddressBookMobile>(entity =>
            {

                entity.Property(e => e.attentionDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.company)
                    .HasMaxLength(100);

                entity.Property(e => e.createDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.mobile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.name)
                    .HasMaxLength(50);

                entity.Property(e => e.timestamp)
                    .IsRowVersion();

            });

            modelBuilder.Entity<AssociatedProjRecord>(entity =>
            {

                entity.Property(e => e.created)
                    .HasColumnType("datetime");

            });

            modelBuilder.Entity<AttentionStatistics>(entity =>
            {


                entity.Property(e => e.date)
                    .HasColumnType("datetime");

                entity.Property(e => e.successRate)
                    .HasColumnType("decimal(18, 0)");

            });

            modelBuilder.Entity<CallRecord>(entity =>
            {
                entity.Property(e => e.created)
                    .HasColumnType("datetime");

            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.classId);

                entity.Property(e => e.endDate)
                    .HasColumnType("datetime");


                entity.Property(e => e.name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.property)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.startDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.type)
                .HasColumnType("tinyint");
            });

            modelBuilder.Entity<ClassStuRelation>(entity =>
            {
                entity.HasKey(e => e.rid)
                    .HasName("PK__ClassStu__C2B7EDE869FBBC1F");

                entity.Property(e => e.payState)
               .HasColumnType("tinyint");

                entity.Property(e => e.committeeType)
               .HasColumnType("tinyint");
            });

            modelBuilder.Entity<DockedRecord>(entity =>
            {
                entity.HasKey(e => e.rid);

                entity.Property(e => e.created)
                    .HasColumnType("datetime");

                entity.Property(e => e.message)
                    .HasMaxLength(300);

                entity.Property(e => e.updated)
                    .HasColumnType("datetime");

                entity.Property(e => e.status)
             .HasColumnType("tinyint");
            });

            modelBuilder.Entity<DockedStatistics>(entity =>
            {
                entity.Property(e => e.date)
                    .HasColumnType("datetime");

            });

            modelBuilder.Entity<FootPrint>(entity =>
            {
                entity.HasKey(e => e.fid);

                entity.HasIndex(e => new { e.pid, e.orderUpdated })
                    .HasName("IX_FootPrint");


                entity.Property(e => e.address)
                    .HasMaxLength(200);

                entity.Property(e => e.areaNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.content)
                    .HasMaxLength(1000);

                entity.Property(e => e.created)
                    .HasColumnType("datetime");

                entity.Property(e => e.examinRemarks)
                    .HasMaxLength(200);

                entity.Property(e => e.examineDate)
                    .HasColumnType("datetime");


                entity.Property(e => e.isEnable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.orderUpdated)
                    .HasColumnName("orderUpdated")
                    .HasColumnType("datetime");

                entity.Property(e => e.transferUpdated)
                    .HasColumnType("datetime");


                entity.Property(e => e.updated)
                    .HasColumnType("datetime");

                entity.Property(e => e.verifiedlockDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.state)
             .HasColumnType("tinyint");

                entity.Property(e => e.transferScales)
             .HasColumnType("tinyint");
            });

            modelBuilder.Entity<FootPrintImg>(entity =>
            {

                entity.Property(e => e.address)
                    .HasMaxLength(200);

                entity.Property(e => e.comfirmDate)
                    .HasColumnType("datetime");


                entity.Property(e => e.created)
                    .HasColumnType("datetime");


                entity.Property(e => e.imageKey)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);


                entity.Property(e => e.isEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.photoTime)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<FootPrintStatistics>(entity =>
            {
                entity.Property(e => e.date)
                    .HasColumnType("datetime");

            });

            modelBuilder.Entity<FootPrintTag>(entity =>
            {
                entity.HasKey(e => new { e.fid, e.tid });

                entity.Property(e => e.updated)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<FootUser>(entity =>
            {
                entity.HasKey(e => e.uid);

                entity.HasIndex(e => e.mobile)
                    .HasName("IX_FootUser")
                    .IsUnique();

                entity.Property(e => e.uid)
                    .ValueGeneratedNever();

                entity.Property(e => e.areaNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.company)
                    .HasMaxLength(100);

                entity.Property(e => e.cover)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.created)
                    .HasColumnType("datetime");

                entity.Property(e => e.job)
                    .HasMaxLength(30);

                entity.Property(e => e.lastLogin)
                    .HasColumnType("datetime");

                entity.Property(e => e.lockDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.lockReason)
                    .HasMaxLength(200);

                entity.Property(e => e.mobile)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.name)
                    .HasMaxLength(30);

                entity.Property(e => e.password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.submiVerifytDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.userFacePah)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.userFacePathSmall)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.verifiedlockDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.verifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.verifyFailReason)
                    .HasMaxLength(200);

                entity.Property(e => e.verifyImage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.verifyStatus)
                .HasColumnType("tinyint");

                entity.Property(e => e.sex)
               .HasColumnType("tinyint");


            });

            modelBuilder.Entity<ImportFootPrintRecord>(entity =>
            {
                entity.Property(e => e.unSuccessReason)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ImportUserRecord>(entity =>
            {
                entity.HasKey(e => e.uid);

                entity.Property(e => e.uid)
                    .ValueGeneratedNever();

                entity.Property(e => e.importTime)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<InstitudeOfGrowthTrade>(entity =>
            {
                entity.HasKey(e => e.tradeNo);

                entity.Property(e => e.tradeNo)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.created)
                    .HasColumnType("datetime");

                entity.Property(e => e.extension)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.paied)
                    .HasColumnType("datetime");

                entity.Property(e => e.successed)
                    .HasColumnType("datetime");

                entity.Property(e => e.total)
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.type)
               .HasColumnType("tinyint");

                entity.Property(e => e.payment)
             .HasColumnType("tinyint");

                entity.Property(e => e.pType)
             .HasColumnType("tinyint");

            });

            modelBuilder.Entity<InteractionStatistics>(entity =>
            {
                entity.Property(e => e.date)
                    .HasColumnType("datetime");

            });

            modelBuilder.Entity<MobileInfo>(entity =>
            {
                entity.HasKey(e => new { e.uid, e.deviceId });

                entity.Property(e => e.deviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.clientVersion)
                    .HasMaxLength(50);

                entity.Property(e => e.ip)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.os)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.resolution)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.trademark)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.updated)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Relation>(entity =>
            {
                entity.HasKey(e => new { e.sender, e.receiver });

                entity.Property(e => e.createDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.description)
                    .HasMaxLength(150);


                entity.Property(e => e.message)
                    .HasMaxLength(200);

                entity.Property(e => e.remark)
                    .HasMaxLength(20);

                entity.Property(e => e.updateDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.rType)
             .HasColumnType("tinyint");

            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.uid);

                entity.Property(e => e.uid)
                    .ValueGeneratedNever();

                entity.Property(e => e.bussinessAreas)
                    .HasMaxLength(100);

                entity.Property(e => e.buyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.company)
                    .HasMaxLength(50);

                entity.Property(e => e.created)
                    .HasColumnType("datetime");

                entity.Property(e => e.job)
                    .HasMaxLength(20);

                entity.Property(e => e.name)
                    .HasMaxLength(10);

                entity.Property(e => e.necessaryDoType)
                    .HasMaxLength(50);

                entity.Property(e => e.needCooperateProduct)
                    .HasMaxLength(200);

                entity.Property(e => e.needCustomSource)
                    .HasMaxLength(200);

                entity.Property(e => e.products)
                    .HasMaxLength(200);

                entity.Property(e => e.stageNos)
                    .HasMaxLength(200);

                entity.Property(e => e.updated)
                    .HasColumnType("datetime");

                entity.Property(e => e.weChat)
                    .HasMaxLength(50);

                entity.Property(e => e.sex)
             .HasColumnType("tinyint");
            });

            modelBuilder.Entity<SuggestFeedback>(entity =>
            {
                entity.Property(e => e.content)
                    .IsRequired()
                    .HasMaxLength(250);

            });

            modelBuilder.Entity<TagSource>(entity =>
            {
                entity.HasKey(e => e.tid);

                entity.Property(e => e.created)
                    .HasColumnType("datetime");

                entity.Property(e => e.name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.updated)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TouristViewFootPrintRecord>(entity =>
            {
                entity.HasKey(e => new { e.devieceId, e.fid });

                entity.Property(e => e.devieceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.updated)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Trade>(entity =>
            {
                entity.HasKey(e => e.tradeNo);

                entity.Property(e => e.tradeNo)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.created)
                    .HasColumnType("datetime");

                entity.Property(e => e.extension)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.paied)
                    .HasColumnType("datetime");

                entity.Property(e => e.successed)
                    .HasColumnType("datetime");

                entity.Property(e => e.total)
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.type)
             .HasColumnType("tinyint");

                entity.Property(e => e.payment)
             .HasColumnType("tinyint");

            });

            modelBuilder.Entity<UserBrand>(entity =>
            {
                entity.HasKey(e => e.bid);

                entity.Property(e => e.name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.updated)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<UserBusinessArea>(entity =>
            {
                entity.HasKey(e => new { e.uid, e.areaNo });

                entity.Property(e => e.areaNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.created)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<UserComplain>(entity =>
            {
                entity.Property(e => e.content)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.created)
                    .HasColumnType("datetime");

                entity.Property(e => e.kind)
             .HasColumnType("tinyint");

            });

            modelBuilder.Entity<UserFavorite>(entity =>
            {
                entity.HasKey(e => new { e.uid, e.pid });

                entity.Property(e => e.isEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

            });

            modelBuilder.Entity<UserLoginRecord>(entity =>
            {
                entity.Property(e => e.ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.loginTime)
                    .HasColumnType("datetime");

            });

            modelBuilder.Entity<UserProduct>(entity =>
            {
                entity.HasKey(e => e.pid);

                entity.Property(e => e.name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.updated)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<FootCharUserServiceState>(entity =>
            {
                entity.ToTable("UserServiceState");

                entity.HasKey(e => e.uid);

                entity.Property(e => e.uid)
                    .ValueGeneratedNever();

                entity.Property(e => e.expired)
                    .HasColumnType("datetime");

                entity.Property(e => e.updated)
                    .HasColumnType("datetime");

                entity.Property(e => e.level)
             .HasColumnType("tinyint");
            });

            modelBuilder.Entity<UserServiceStateUpdateRecord>(entity =>
            {
                entity.HasKey(e => e.rid);

                entity.Property(e => e.creted)
                    .HasColumnType("datetime");

                entity.Property(e => e.remark)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.type)
             .HasColumnType("tinyint");

            });

            modelBuilder.Entity<UserSetting>(entity =>
            {
                entity.HasKey(e => e.uid);

                entity.Property(e => e.uid)
                    .ValueGeneratedNever();

                entity.Property(e => e.settingTime)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<UserStatistics>(entity =>
            {
                entity.Property(e => e.date)
                    .HasColumnType("datetime");

                entity.Property(e => e.paidRate)
                    .HasColumnType("decimal(18, 0)");

            });

            modelBuilder.Entity<UserViewFootPrintRecord>(entity =>
            {
                entity.HasKey(e => new { e.uid, e.fid });

                entity.Property(e => e.updated)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<UserViewProjFootListRecord>(entity =>
            {
                entity.HasKey(e => new { e.uid, e.pid });

                entity.Property(e => e.updated)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<UserViewProjRecord>(entity =>
            {
                entity.HasKey(e => new { e.pid, e.uid })
                    .HasName("PK_UserViewProjRecord_1");

                entity.Property(e => e.updated)
                    .HasColumnType("datetime");
            });
        }
    }
}
