using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class imageadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Celebis");

            migrationBuilder.DropTable(
                name: "Cerpas");

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
                name: "Parses");

            migrationBuilder.DropTable(
                name: "Proxes");

            migrationBuilder.DropTable(
                name: "Stds");

            migrationBuilder.DropTable(
                name: "TakımCantas");

            migrationBuilder.DropTable(
                name: "tomaxes");

            migrationBuilder.DropTable(
                name: "Tursans");

            migrationBuilder.DropTable(
                name: "Yumas");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.CreateTable(
                name: "Asyems",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asyems", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Atlases",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atlases", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Ballies",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ballies", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Baytases",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baytases", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Besels",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besels", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "BmiTerazis",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BmiTerazis", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Candans",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candans", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Celebis",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celebis", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Cerpas",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cerpas", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Daysons",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daysons", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Difixes",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Difixes", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Duyars",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duyars", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Eltos",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eltos", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ErsaMils",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErsaMils", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ErsaPitons",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErsaPitons", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Fircas",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fircas", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Inans",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inans", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Ithals",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ithals", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Izeltas",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izeltas", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "kales",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kales", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Karbosans",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karbosans", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Korals",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korals", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Mades",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mades", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "MaxExtras",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaxExtras", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Mtes",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mtes", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Nursans",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nursans", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Parses",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parses", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Proxes",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proxes", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stds",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stds", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "TakımCantas",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakımCantas", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "tomaxes",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tomaxes", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Tursans",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tursans", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Yumas",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BoxSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxSizeEng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metarial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWeight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yumas", x => x.ProductId);
                });
        }
    }
}
