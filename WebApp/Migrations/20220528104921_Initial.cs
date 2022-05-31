using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransportCost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mark",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MarkName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mark", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepairCost",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FaultDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    IsRejected = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairCost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RepairStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Repair",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickupDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeviceModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Describe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Warranty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tracking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RepairCostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AddressId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DeviceTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MarkId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repair", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Repair_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Repair_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Repair_DeviceType_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Repair_Mark_MarkId",
                        column: x => x.MarkId,
                        principalTable: "Mark",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Repair_RepairCost_RepairCostId",
                        column: x => x.RepairCostId,
                        principalTable: "RepairCost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Repair_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "FirstName", "LastName", "PhoneNumber", "PostalCode", "Street" },
                values: new object[,]
                {
                    { "23c39e5a-e895-403f-93a7-35b158406a90", "Kraków", "Stanisław", "Jabłoński", 786828418, 30614, "ul. Błogosławionej Siedliskiej Franciszki 62" },
                    { "279a5460-e35b-4fd7-8638-3622cd4a3cd2", "Warszawa", "Karina", "Nowicka", 793247715, 2198, "ul. Kinetyczna 85" },
                    { "2a94b702-1a9a-4213-b717-c3123a3b418d", "Warszawa", "Joasia", "Kowalczyk", 723999750, 1715, "ul. Kłodawska 87" },
                    { "eef356f9-faf4-44ad-8c7f-d45929612e94", "Kraków", "Klaudia", "Rutkowska", 722623711, 30419, "ul. Deotymy 12" },
                    { "f8612490-adb6-4574-8d6f-7a16ca2d2167", "Wrocław", "Iwo", "Adamczyk", 888569892, 50111, "ul. Malarska 107" }
                });

            migrationBuilder.InsertData(
                table: "DeviceType",
                columns: new[] { "Id", "DeviceName", "TransportCost" },
                values: new object[,]
                {
                    { "29e93e52-abf3-48f0-a00f-bb9df2896ef1", "Inne", 0.0 },
                    { "2d843e17-d463-4155-94ac-7f9c14a1596c", "Zmywarka", 50.0 },
                    { "53fae8a6-9c12-4d4b-8cde-d61035913035", "Indukcja", 40.0 },
                    { "785d270c-0d57-4787-90e3-f23da5e9ed35", "Mikrofalówka", 30.0 },
                    { "7d0830a0-eaad-48af-9089-50cc421f8bcb", "Pralka", 50.0 },
                    { "9828b4b7-1bfb-450f-a681-86ac9f48c0b3", "Piekarnik", 50.0 },
                    { "d152a77b-108e-4ca6-825b-a944bec3b3d5", "Telewizor", 100.0 },
                    { "e9a93ab9-e2e0-4fcb-8bd6-e75a037c3064", "Lodówka", 100.0 }
                });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "Id", "MarkName" },
                values: new object[,]
                {
                    { "01bb89d3-1433-4b64-8f8e-dd92fe339775", "Logitech" },
                    { "045a1297-5b86-45df-ac41-4b29246026a0", "Huawei" },
                    { "16408fe4-7bc7-4bb0-87b5-87f1c1fcadca", "Samsung" },
                    { "88c4a037-d5b0-4ae6-bb06-5e9f7bcd9b2a", "Philips" },
                    { "a14e4c37-8731-42d9-845f-d7a953293277", "Sony" },
                    { "a2b855fa-d60d-4d74-869a-a3e588a79c1e", "AEG" },
                    { "a75fc129-21c7-4744-95c1-2f4664644d0e", "Whirlpool" },
                    { "d96adae8-2cbb-4e86-aeb0-4ae81753b221", "Amica" },
                    { "e4a48371-d3e6-46c6-b12f-11b478832e2c", "Bosh" },
                    { "f5775945-cd35-4806-a8ab-66654765eb54", "Siemens" }
                });

            migrationBuilder.InsertData(
                table: "RepairCost",
                columns: new[] { "Id", "Cost", "FaultDescription", "IsAccepted", "IsRejected" },
                values: new object[,]
                {
                    { "1b972b4b-b3b7-451d-bc6a-f8c9afc04846", 67.599999999999994, "Uszkodzone drzwi.", true, false },
                    { "92862e92-14c9-475e-b409-5e5dd8c3eec4", 67.599999999999994, "Uszkodzony silnik.", true, false },
                    { "d8a23637-e6a9-4289-a15d-eaf289e92be9", 67.599999999999994, "Uszkodzony kabel.", true, false }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "RepairStatus" },
                values: new object[,]
                {
                    { "0368748a-9909-439f-a7f6-2a99305384fe", "Anulowano" },
                    { "2e3945fc-4224-4823-846c-0bd9b21c4a42", "Wysłano kuriera" },
                    { "52008a41-7ad2-4829-aebc-d774d6930067", "Wysłano sprzęt do klienta" },
                    { "5b04558d-9220-4157-a4bd-6a043151c497", "Cena naprawy odrzucona" },
                    { "c7cce1d7-7fde-4c2b-a917-69e077833e89", "Naprawa zakończona" },
                    { "cf59fb12-f701-4f6f-8e71-cf596182aa1c", "Oczekiwanie na akceptacje" },
                    { "d85e2d83-c471-4083-8974-48fd08e68611", "Zakończono" },
                    { "f6d17df2-4c05-4985-8779-6a71ec06a314", "Wycena" },
                    { "f8bcfcd1-f9a5-4f28-96a0-a73c906c7159", "Naprawa została zgłoszona" },
                    { "fbf91ffa-1090-4a99-8763-face6e977006", "Cena naprawy zaakceptowana" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_AddressId",
                table: "Repair",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_DeviceTypeId",
                table: "Repair",
                column: "DeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_MarkId",
                table: "Repair",
                column: "MarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_RepairCostId",
                table: "Repair",
                column: "RepairCostId");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_StatusId",
                table: "Repair",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Repair_UserId",
                table: "Repair",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Repair");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DeviceType");

            migrationBuilder.DropTable(
                name: "Mark");

            migrationBuilder.DropTable(
                name: "RepairCost");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
