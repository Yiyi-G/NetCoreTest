using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tgnet.FootChat.Migrations
{
    public partial class initDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "AddressBookMobile",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    uid = table.Column<long>(nullable: false),
                    mobile = table.Column<string>(maxLength: 50, nullable: false),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    company = table.Column<string>(maxLength: 100, nullable: true),
                    haveRecommended = table.Column<bool>(nullable: false),
                    tguid = table.Column<long>(nullable: true),
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    isAttention = table.Column<bool>(nullable: false),
                    attentionDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressBookMobile", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AssociatedProjRecord",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fid = table.Column<long>(nullable: false),
                    oldProjId = table.Column<long>(nullable: false),
                    newProjId = table.Column<long>(nullable: false),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    @operator = table.Column<long>(name: "operator", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociatedProjRecord", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AttentionStatistics",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    attentionCount = table.Column<int>(nullable: false),
                    todayAttentionCount = table.Column<int>(nullable: false),
                    attentionUserCount = table.Column<int>(nullable: false),
                    todayAttentionUserCount = table.Column<int>(nullable: false),
                    invitationCount = table.Column<int>(nullable: false),
                    todayInvitationCount = table.Column<int>(nullable: false),
                    successRate = table.Column<decimal>(type: "decimal(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttentionStatistics", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CallRecord",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    caller = table.Column<long>(nullable: false),
                    receiver = table.Column<long>(nullable: false),
                    created = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallRecord", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    classId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 20, nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    property = table.Column<string>(maxLength: 50, nullable: false),
                    type = table.Column<byte>(type: "tinyint", nullable: false),
                    isEnable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.classId);
                });

            migrationBuilder.CreateTable(
                name: "ClassStuRelation",
                columns: table => new
                {
                    rid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    classId = table.Column<long>(nullable: false),
                    uid = table.Column<long>(nullable: false),
                    payState = table.Column<byte>(type: "tinyint", nullable: false),
                    committeeType = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ClassStu__C2B7EDE869FBBC1F", x => x.rid);
                });

            migrationBuilder.CreateTable(
                name: "DockedRecord",
                columns: table => new
                {
                    rid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fid = table.Column<long>(nullable: false),
                    sender = table.Column<long>(nullable: false),
                    receiver = table.Column<long>(nullable: false),
                    status = table.Column<byte>(type: "tinyint", nullable: false),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false),
                    message = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DockedRecord", x => x.rid);
                });

            migrationBuilder.CreateTable(
                name: "DockedStatistics",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    dockedTotalNum = table.Column<int>(nullable: false),
                    todayDockedNum = table.Column<int>(nullable: false),
                    todaySuccessfulDockedNum = table.Column<int>(nullable: false),
                    agreedDockedTotalNum = table.Column<int>(nullable: false),
                    todayAgreedDockedNum = table.Column<int>(nullable: false),
                    todayRejectedDockedNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DockedStatistics", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FootPrint",
                columns: table => new
                {
                    fid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    uid = table.Column<long>(nullable: false),
                    pid = table.Column<long>(nullable: false),
                    content = table.Column<string>(maxLength: 1000, nullable: true),
                    address = table.Column<string>(maxLength: 200, nullable: true),
                    longitude = table.Column<double>(nullable: true),
                    latitude = table.Column<double>(nullable: true),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false),
                    state = table.Column<byte>(type: "tinyint", nullable: false),
                    examiner = table.Column<long>(nullable: true),
                    examineDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    examinRemarks = table.Column<string>(maxLength: 200, nullable: true),
                    transferScales = table.Column<byte>(type: "tinyint", nullable: false),
                    transferState = table.Column<byte>(nullable: false),
                    transferOperator = table.Column<long>(nullable: true),
                    transferUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    isEnable = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    orderUpdated = table.Column<DateTime>(type: "datetime", nullable: false),
                    areaNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    tgFid = table.Column<long>(nullable: false),
                    isVerifiedLocked = table.Column<bool>(nullable: false),
                    verifiedlockDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootPrint", x => x.fid);
                });

            migrationBuilder.CreateTable(
                name: "FootPrintImg",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fid = table.Column<long>(nullable: false),
                    imageKey = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    longitude = table.Column<double>(nullable: true),
                    latitude = table.Column<double>(nullable: true),
                    address = table.Column<string>(maxLength: 200, nullable: true),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    photoTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    isEnabled = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    order = table.Column<int>(nullable: true),
                    isComfirm = table.Column<bool>(nullable: false),
                    comfirmDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    comfirmer = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootPrintImg", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FootPrintStatistics",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    totalCount = table.Column<int>(nullable: false),
                    todayPassFootPrintCount = table.Column<int>(nullable: false),
                    todayUnPassFootPrintCount = table.Column<int>(nullable: false),
                    creatorCount = table.Column<int>(nullable: false),
                    todayCreatorCount = table.Column<int>(nullable: false),
                    fpViewCount = table.Column<int>(nullable: false),
                    totalViewUserCount = table.Column<int>(nullable: false),
                    gt2FollowProjNum = table.Column<int>(nullable: false),
                    gt2FollowUserNum = table.Column<int>(nullable: false),
                    totalPassFootPrintCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootPrintStatistics", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FootPrintTag",
                columns: table => new
                {
                    fid = table.Column<long>(nullable: false),
                    tid = table.Column<long>(nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootPrintTag", x => new { x.fid, x.tid });
                });

            migrationBuilder.CreateTable(
                name: "FootUser",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false),
                    mobile = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    password = table.Column<string>(maxLength: 100, nullable: false),
                    name = table.Column<string>(maxLength: 30, nullable: true),
                    areaNo = table.Column<string>(maxLength: 50, nullable: false),
                    sex = table.Column<byte>(type: "tinyint", nullable: true),
                    company = table.Column<string>(maxLength: 100, nullable: true),
                    job = table.Column<string>(maxLength: 30, nullable: true),
                    verifyStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    verifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    verifyUser = table.Column<long>(nullable: true),
                    verifyFailReason = table.Column<string>(maxLength: 200, nullable: true),
                    submiVerifytDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    verifyImage = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    isInner = table.Column<bool>(nullable: false),
                    lastLogin = table.Column<DateTime>(type: "datetime", nullable: false),
                    loginCount = table.Column<int>(nullable: false),
                    isLocked = table.Column<bool>(nullable: false),
                    lockReason = table.Column<string>(maxLength: 200, nullable: true),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    userFacePah = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    userFacePathSmall = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    lockDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    lockOperator = table.Column<long>(nullable: true),
                    isNeedVerify = table.Column<bool>(nullable: false),
                    cover = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    isVerifiedLocked = table.Column<bool>(nullable: false),
                    verifiedlockDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootUser", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "ImportFootPrintRecord",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isSuccess = table.Column<bool>(nullable: false),
                    fid = table.Column<long>(nullable: false),
                    uid = table.Column<long>(nullable: false),
                    unSuccessReason = table.Column<string>(maxLength: 200, nullable: false),
                    tgFid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportFootPrintRecord", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ImportUserRecord",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false),
                    importTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportUserRecord", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "InstitudeOfGrowthTrade",
                columns: table => new
                {
                    tradeNo = table.Column<string>(maxLength: 50, nullable: false),
                    uid = table.Column<long>(nullable: false),
                    isPaied = table.Column<bool>(nullable: false),
                    type = table.Column<byte>(type: "tinyint", nullable: false),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    paied = table.Column<DateTime>(type: "datetime", nullable: true),
                    total = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    extension = table.Column<string>(maxLength: 2000, nullable: false),
                    buySuccess = table.Column<bool>(nullable: false),
                    seller = table.Column<long>(nullable: true),
                    payment = table.Column<byte>(type: "tinyint", nullable: false),
                    successed = table.Column<DateTime>(type: "datetime", nullable: true),
                    pType = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitudeOfGrowthTrade", x => x.tradeNo);
                });

            migrationBuilder.CreateTable(
                name: "InteractionStatistics",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    callTotalNum = table.Column<int>(nullable: false),
                    todayCallTotalNum = table.Column<int>(nullable: false),
                    callUserNum = table.Column<int>(nullable: false),
                    vipCallTotalNum = table.Column<int>(nullable: false),
                    vipTodayCallTotalNum = table.Column<int>(nullable: false),
                    vipCallUserNum = table.Column<int>(nullable: false),
                    todayVipCallUserNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InteractionStatistics", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MobileInfo",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false),
                    deviceId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    resolution = table.Column<string>(maxLength: 50, nullable: false),
                    os = table.Column<string>(maxLength: 50, nullable: false),
                    trademark = table.Column<string>(maxLength: 50, nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false),
                    ip = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    clientVersion = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileInfo", x => new { x.uid, x.deviceId });
                });

            migrationBuilder.CreateTable(
                name: "Relation",
                columns: table => new
                {
                    sender = table.Column<long>(nullable: false),
                    receiver = table.Column<long>(nullable: false),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    updateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    rType = table.Column<byte>(type: "tinyint", nullable: false),
                    inReceiverBlack = table.Column<bool>(nullable: false),
                    inSenderBlack = table.Column<bool>(nullable: false),
                    isStar = table.Column<bool>(nullable: false),
                    remark = table.Column<string>(maxLength: 20, nullable: true),
                    description = table.Column<string>(maxLength: 150, nullable: true),
                    from = table.Column<byte>(nullable: false),
                    dateVersion = table.Column<long>(nullable: false),
                    isNotNotiry = table.Column<bool>(nullable: false),
                    inSession = table.Column<bool>(nullable: false),
                    message = table.Column<string>(maxLength: 200, nullable: true),
                    sessionTop = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relation", x => new { x.sender, x.receiver });
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false),
                    name = table.Column<string>(maxLength: 10, nullable: true),
                    sex = table.Column<byte>(type: "tinyint", nullable: true),
                    weChat = table.Column<string>(maxLength: 50, nullable: true),
                    products = table.Column<string>(maxLength: 200, nullable: true),
                    company = table.Column<string>(maxLength: 50, nullable: true),
                    job = table.Column<string>(maxLength: 20, nullable: true),
                    bussinessAreas = table.Column<string>(maxLength: 100, nullable: true),
                    yearOfWorking = table.Column<int>(nullable: true),
                    stageNos = table.Column<string>(maxLength: 200, nullable: true),
                    needCustomSource = table.Column<string>(maxLength: 200, nullable: true),
                    needCooperateProduct = table.Column<string>(maxLength: 200, nullable: true),
                    lastYearAchievement = table.Column<double>(nullable: true),
                    thisYearGoal = table.Column<double>(nullable: true),
                    necessaryDoType = table.Column<string>(maxLength: 50, nullable: true),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false),
                    isBuy = table.Column<bool>(nullable: false),
                    buyDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "SuggestFeedback",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    uid = table.Column<long>(nullable: false),
                    content = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuggestFeedback", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TagSource",
                columns: table => new
                {
                    tid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    isEnable = table.Column<bool>(nullable: false),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    @operator = table.Column<long>(name: "operator", nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false),
                    order = table.Column<int>(nullable: false),
                    gid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagSource", x => x.tid);
                });

            migrationBuilder.CreateTable(
                name: "TouristViewFootPrintRecord",
                columns: table => new
                {
                    devieceId = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    fid = table.Column<long>(nullable: false),
                    count = table.Column<int>(nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TouristViewFootPrintRecord", x => new { x.devieceId, x.fid });
                });

            migrationBuilder.CreateTable(
                name: "Trade",
                columns: table => new
                {
                    tradeNo = table.Column<string>(maxLength: 50, nullable: false),
                    uid = table.Column<long>(nullable: false),
                    isPaied = table.Column<bool>(nullable: false),
                    type = table.Column<byte>(type: "tinyint", nullable: false),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    paied = table.Column<DateTime>(type: "datetime", nullable: true),
                    total = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    isDelete = table.Column<bool>(nullable: false),
                    extension = table.Column<string>(maxLength: 2000, nullable: false),
                    buySuccess = table.Column<bool>(nullable: false),
                    seller = table.Column<long>(nullable: true),
                    payment = table.Column<byte>(type: "tinyint", nullable: false),
                    successed = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trade", x => x.tradeNo);
                });

            migrationBuilder.CreateTable(
                name: "UserBrand",
                columns: table => new
                {
                    bid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    uid = table.Column<long>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBrand", x => x.bid);
                });

            migrationBuilder.CreateTable(
                name: "UserBusinessArea",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false),
                    areaNo = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    created = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBusinessArea", x => new { x.uid, x.areaNo });
                });

            migrationBuilder.CreateTable(
                name: "UserComplain",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    uid = table.Column<long>(nullable: false),
                    content = table.Column<string>(maxLength: 200, nullable: false),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    kind = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComplain", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserFavorite",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false),
                    pid = table.Column<long>(nullable: false),
                    isEnabled = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Updated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavorite", x => new { x.uid, x.pid });
                });

            migrationBuilder.CreateTable(
                name: "UserLoginRecord",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    uid = table.Column<long>(nullable: false),
                    ip = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    loginTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLoginRecord", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserProduct",
                columns: table => new
                {
                    pid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    uid = table.Column<long>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProduct", x => x.pid);
                });

            migrationBuilder.CreateTable(
                name: "UserServiceState",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false),
                    level = table.Column<byte>(type: "tinyint", nullable: false),
                    expired = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserServiceState", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "UserServiceStateUpdateRecord",
                columns: table => new
                {
                    rid = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    uid = table.Column<long>(nullable: false),
                    type = table.Column<byte>(nullable: false),
                    creted = table.Column<DateTime>(type: "datetime", nullable: false),
                    IncreaseDays = table.Column<int>(nullable: false),
                    remark = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserServiceStateUpdateRecord", x => x.rid);
                });

            migrationBuilder.CreateTable(
                name: "UserSetting",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false),
                    isOpenVoice = table.Column<bool>(nullable: false),
                    isOpenShake = table.Column<bool>(nullable: false),
                    isOpenNightQuiet = table.Column<bool>(nullable: false),
                    isPushNotify = table.Column<bool>(nullable: false),
                    settingTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSetting", x => x.uid);
                });

            migrationBuilder.CreateTable(
                name: "UserStatistics",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    totalCount = table.Column<int>(nullable: false),
                    todayCreatedCount = table.Column<int>(nullable: false),
                    verifiedCount = table.Column<int>(nullable: false),
                    todayPassCount = table.Column<int>(nullable: false),
                    todayUnPassCount = table.Column<int>(nullable: false),
                    trailUserCount = table.Column<int>(nullable: false),
                    officialUserCount = table.Column<int>(nullable: false),
                    todayPaidUserCount = table.Column<int>(nullable: false),
                    paidRate = table.Column<decimal>(type: "decimal(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatistics", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserViewFootPrintRecord",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false),
                    fid = table.Column<long>(nullable: false),
                    count = table.Column<int>(nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserViewFootPrintRecord", x => new { x.uid, x.fid });
                });

            migrationBuilder.CreateTable(
                name: "UserViewProjFootListRecord",
                columns: table => new
                {
                    uid = table.Column<long>(nullable: false),
                    pid = table.Column<long>(nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserViewProjFootListRecord", x => new { x.uid, x.pid });
                });

            migrationBuilder.CreateTable(
                name: "UserViewProjRecord",
                columns: table => new
                {
                    pid = table.Column<long>(nullable: false),
                    uid = table.Column<long>(nullable: false),
                    count = table.Column<int>(nullable: false),
                    updated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserViewProjRecord_1", x => new { x.pid, x.uid });
                });

            migrationBuilder.CreateIndex(
                name: "IX_FootPrint",
                table: "FootPrint",
                columns: new[] { "pid", "orderUpdated" });

            migrationBuilder.CreateIndex(
                name: "IX_FootUser",
                table: "FootUser",
                column: "mobile",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropTable(
                name: "AddressBookMobile");

            migrationBuilder.DropTable(
                name: "AssociatedProjRecord");

            migrationBuilder.DropTable(
                name: "AttentionStatistics");

            migrationBuilder.DropTable(
                name: "CallRecord");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "ClassStuRelation");

            migrationBuilder.DropTable(
                name: "DockedRecord");

            migrationBuilder.DropTable(
                name: "DockedStatistics");

            migrationBuilder.DropTable(
                name: "FootPrint");

            migrationBuilder.DropTable(
                name: "FootPrintImg");

            migrationBuilder.DropTable(
                name: "FootPrintStatistics");

            migrationBuilder.DropTable(
                name: "FootPrintTag");

            migrationBuilder.DropTable(
                name: "FootUser");

            migrationBuilder.DropTable(
                name: "ImportFootPrintRecord");

            migrationBuilder.DropTable(
                name: "ImportUserRecord");

            migrationBuilder.DropTable(
                name: "InstitudeOfGrowthTrade");

            migrationBuilder.DropTable(
                name: "InteractionStatistics");

            migrationBuilder.DropTable(
                name: "MobileInfo");

            migrationBuilder.DropTable(
                name: "Relation");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "SuggestFeedback");

            migrationBuilder.DropTable(
                name: "TagSource");

            migrationBuilder.DropTable(
                name: "TouristViewFootPrintRecord");

            migrationBuilder.DropTable(
                name: "Trade");

            migrationBuilder.DropTable(
                name: "UserBrand");

            migrationBuilder.DropTable(
                name: "UserBusinessArea");

            migrationBuilder.DropTable(
                name: "UserComplain");

            migrationBuilder.DropTable(
                name: "UserFavorite");

            migrationBuilder.DropTable(
                name: "UserLoginRecord");

            migrationBuilder.DropTable(
                name: "UserProduct");

            migrationBuilder.DropTable(
                name: "UserServiceState");

            migrationBuilder.DropTable(
                name: "UserServiceStateUpdateRecord");

            migrationBuilder.DropTable(
                name: "UserSetting");

            migrationBuilder.DropTable(
                name: "UserStatistics");

            migrationBuilder.DropTable(
                name: "UserViewFootPrintRecord");

            migrationBuilder.DropTable(
                name: "UserViewProjFootListRecord");

            migrationBuilder.DropTable(
                name: "UserViewProjRecord");
        }
    }
}
