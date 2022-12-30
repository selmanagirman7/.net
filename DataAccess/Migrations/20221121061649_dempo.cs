using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class dempo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(nullable: true),
                    AboutTitleEng = table.Column<string>(nullable: true),
                    AboutName = table.Column<string>(nullable: true),
                    AboutNameEng = table.Column<string>(nullable: true),
                    AboutDescription = table.Column<string>(nullable: true),
                    AboutDescriptionEng = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    ValueEng = table.Column<string>(nullable: true),
                    Mission = table.Column<string>(nullable: true),
                    MissionEng = table.Column<string>(nullable: true),
                    Vission = table.Column<string>(nullable: true),
                    VissionEng = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Asyems",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asyems", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Atlases",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atlases", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Ballies",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ballies", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Baytases",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baytases", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Besels",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besels", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "BmiTerazis",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BmiTerazis", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Candans",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candans", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Celebis",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celebis", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Cerpas",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cerpas", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyNameEng = table.Column<string>(nullable: true),
                    CompanyPhone = table.Column<string>(nullable: true),
                    CompanyPhone2 = table.Column<string>(nullable: true),
                    ComponayMail = table.Column<string>(nullable: true),
                    CompanyAdress = table.Column<string>(nullable: true),
                    CompanyAdressEng = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerNameEng = table.Column<string>(nullable: true),
                    CustomerMail = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Massage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Corporates",
                columns: table => new
                {
                    CorporateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    TitleEng = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    DescEng = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporates", x => x.CorporateId);
                });

            migrationBuilder.CreateTable(
                name: "Daysons",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daysons", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Difixes",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Difixes", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Duyars",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duyars", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Eltos",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eltos", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ErsaMils",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErsaMils", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ErsaPitons",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErsaPitons", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Fircas",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fircas", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Galeries",
                columns: table => new
                {
                    GaleryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageTitle = table.Column<string>(nullable: true),
                    PageTitleEng = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galeries", x => x.GaleryId);
                });

            migrationBuilder.CreateTable(
                name: "HomeAbouts",
                columns: table => new
                {
                    HomeAboutId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feature = table.Column<string>(nullable: true),
                    FeatureEng = table.Column<string>(nullable: true),
                    Feature2 = table.Column<string>(nullable: true),
                    Feature2Eng = table.Column<string>(nullable: true),
                    FeatureDesc = table.Column<string>(nullable: true),
                    FeatureDescEng = table.Column<string>(nullable: true),
                    FeatureDesc2 = table.Column<string>(nullable: true),
                    FeatureDesc2Eng = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeAbouts", x => x.HomeAboutId);
                });

            migrationBuilder.CreateTable(
                name: "Inans",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inans", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Ithals",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ithals", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Izeltas",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izeltas", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "kales",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kales", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Karbosans",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karbosans", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Korals",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korals", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Mades",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mades", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "MaxExtras",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaxExtras", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Mtes",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mtes", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Nursans",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nursans", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "OurServices",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    TitleEng = table.Column<string>(nullable: true),
                    Feature = table.Column<string>(nullable: true),
                    FeatureEng = table.Column<string>(nullable: true),
                    FeatureDesc = table.Column<string>(nullable: true),
                    FeatureDescEng = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    DescEng = table.Column<string>(nullable: true),
                    FlatIcon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurServices", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "Parses",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parses", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Proxes",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proxes", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Referances",
                columns: table => new
                {
                    ReferanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferanceName = table.Column<string>(nullable: true),
                    ReferanceNameEng = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referances", x => x.ReferanceId);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    SliderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgPath = table.Column<string>(nullable: true),
                    ImgPath2 = table.Column<string>(nullable: true),
                    ImgPath3 = table.Column<string>(nullable: true),
                    ImgPath4 = table.Column<string>(nullable: true),
                    ImgPath5 = table.Column<string>(nullable: true),
                    SliderText = table.Column<string>(nullable: true),
                    EnSliderText = table.Column<string>(nullable: true),
                    SliderText2 = table.Column<string>(nullable: true),
                    EnSliderText2 = table.Column<string>(nullable: true),
                    SliderText3 = table.Column<string>(nullable: true),
                    EnSliderText3 = table.Column<string>(nullable: true),
                    SliderText4 = table.Column<string>(nullable: true),
                    EnSliderText4 = table.Column<string>(nullable: true),
                    SliderText5 = table.Column<string>(nullable: true),
                    EnSliderText5 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.SliderId);
                });

            migrationBuilder.CreateTable(
                name: "Stds",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stds", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "TakımCantas",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakımCantas", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "tomaxes",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tomaxes", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Tursans",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tursans", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "VegaProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    Stok = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    MonyTyp = table.Column<string>(nullable: true),
                    Iskonto = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Statu = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VegaProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yumas",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Metarial = table.Column<string>(nullable: true),
                    SeatAngle = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    Dimensions = table.Column<string>(nullable: true),
                    BoxSize = table.Column<string>(nullable: true),
                    BoxSizeEng = table.Column<string>(nullable: true),
                    ThumbDesc = table.Column<string>(nullable: true),
                    ImgAlt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yumas", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Asyems");

            migrationBuilder.DropTable(
                name: "Atlases");

            migrationBuilder.DropTable(
                name: "Ballies");

            migrationBuilder.DropTable(
                name: "Baytases");

            migrationBuilder.DropTable(
                name: "Besels");

            migrationBuilder.DropTable(
                name: "BmiTerazis");

            migrationBuilder.DropTable(
                name: "Candans");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Celebis");

            migrationBuilder.DropTable(
                name: "Cerpas");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Corporates");

            migrationBuilder.DropTable(
                name: "Daysons");

            migrationBuilder.DropTable(
                name: "Difixes");

            migrationBuilder.DropTable(
                name: "Duyars");

            migrationBuilder.DropTable(
                name: "Eltos");

            migrationBuilder.DropTable(
                name: "ErsaMils");

            migrationBuilder.DropTable(
                name: "ErsaPitons");

            migrationBuilder.DropTable(
                name: "Fircas");

            migrationBuilder.DropTable(
                name: "Galeries");

            migrationBuilder.DropTable(
                name: "HomeAbouts");

            migrationBuilder.DropTable(
                name: "Inans");

            migrationBuilder.DropTable(
                name: "Ithals");

            migrationBuilder.DropTable(
                name: "Izeltas");

            migrationBuilder.DropTable(
                name: "kales");

            migrationBuilder.DropTable(
                name: "Karbosans");

            migrationBuilder.DropTable(
                name: "Korals");

            migrationBuilder.DropTable(
                name: "Mades");

            migrationBuilder.DropTable(
                name: "MaxExtras");

            migrationBuilder.DropTable(
                name: "Mtes");

            migrationBuilder.DropTable(
                name: "Nursans");

            migrationBuilder.DropTable(
                name: "OurServices");

            migrationBuilder.DropTable(
                name: "Parses");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Proxes");

            migrationBuilder.DropTable(
                name: "Referances");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "Stds");

            migrationBuilder.DropTable(
                name: "TakımCantas");

            migrationBuilder.DropTable(
                name: "tomaxes");

            migrationBuilder.DropTable(
                name: "Tursans");

            migrationBuilder.DropTable(
                name: "VegaProducts");

            migrationBuilder.DropTable(
                name: "Yumas");
        }
    }
}
