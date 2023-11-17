using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarListingApp.API.Migrations
{
    /// <inheritdoc />
    public partial class addedidentitytables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Vin",
                value: "9EE1991B-AD9D-4CA0-9D38-B1B55210D019");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Vin",
                value: "D906F5E3-526E-462E-9329-2AB8B3DFBC18");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Vin",
                value: "8971FD6A-5D46-46FD-9941-457CDD86C7B5");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Vin",
                value: "F1884753-2EA4-48DE-89D9-7EE24AD6277D");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Vin",
                value: "ED5AB316-2950-4EC2-B7DD-9212D9476CC8");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Vin",
                value: "8DE4A7C1-0FEE-49A9-847E-CC693849E0E8");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Vin",
                value: "F602684D-480F-4A75-9A3D-E1B276F4300F");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Vin",
                value: "26F01C3A-5033-4277-9560-120E28AD730E");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "Vin",
                value: "E6E74FAB-F4DC-4B75-A6DA-996FA3702C64");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "Vin",
                value: "9BD889B8-520E-464D-A1E0-814981736B83");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "Vin",
                value: "D382ACEF-41E5-4D7F-B998-7037D3409C6E");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "Vin",
                value: "B8C54F4C-8722-4E8F-BC8C-D383BA5A3400");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "Vin",
                value: "14925ED2-0B9E-4854-875D-9E2F30B1425B");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "Vin",
                value: "5F30414E-31E9-4804-B80C-26DC96CA19F8");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "Vin",
                value: "7A405D08-D58A-4CE2-ABFC-8405AC4A43E7");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "Vin",
                value: "D6DE5CB6-5E25-4A61-AC02-31DA9C871A05");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "Vin",
                value: "78CE82F3-6510-48FC-92AF-681831BD9F22");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "Vin",
                value: "9A97B23C-031D-41D3-9460-F20FF9CC0C91");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "Vin",
                value: "ABA38390-3CF6-4F0A-B23C-B6A5D907325B");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "Vin",
                value: "ADA7B432-9E77-4073-9DC6-DEBE0D971FC2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "Vin",
                value: "73EFA40D-2E24-4644-83CB-2B44C217E50C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "Vin",
                value: "D622B45A-AF3B-4B99-9118-E297E6B634D8");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "Vin",
                value: "CEFEE39F-6BA7-4D39-BA98-AD07094BBFE7");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "Vin",
                value: "BC317574-A9B0-49BB-AE7A-63001DD64ABD");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "Vin",
                value: "910E4206-C3BC-4915-B6B4-10CAA94C8207");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "Vin",
                value: "7A6866DF-13F3-4F4D-B619-66A910827906");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "Vin",
                value: "68F6E659-FC0D-454B-8662-89199DCD38B2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "Vin",
                value: "3D79D1FC-1501-4BD7-AE4D-216E0BD60A60");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "Vin",
                value: "8BDB4263-8D0B-4C02-ADF3-F385030A4D8A");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                column: "Vin",
                value: "D7DAC851-C5EA-4057-930A-D3138E4FD722");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                column: "Vin",
                value: "51C213E0-49E4-405B-99D5-81F92F0F3EED");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                column: "Vin",
                value: "1F154091-DED0-4E80-992C-7AAE477985BE");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                column: "Vin",
                value: "E04F2BA8-A157-4775-BFDB-DB4F4F3B47EC");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34,
                column: "Vin",
                value: "A0DDB11C-666E-4E4A-9B7E-EBD8CA6F637D");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35,
                column: "Vin",
                value: "1194127D-E691-44F5-8096-9245C1339461");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36,
                column: "Vin",
                value: "2D0A9611-4321-4B4F-BB1C-32B5D789773C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37,
                column: "Vin",
                value: "7032024C-97AB-409B-8FF6-2C1E468D63F7");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38,
                column: "Vin",
                value: "B674CB75-8B9A-476E-92D9-2045332B168C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39,
                column: "Vin",
                value: "541D5644-9C78-49D5-BE41-0D64CD74E141");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40,
                column: "Vin",
                value: "C25FF597-007F-407E-8AB6-B242BCC330D3");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41,
                column: "Vin",
                value: "72B08361-912A-44AE-B2E6-6563A52A2778");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42,
                column: "Vin",
                value: "78106732-2911-4252-94FE-24B0CC22B7E7");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43,
                column: "Vin",
                value: "5E8158FF-FE02-4E61-BC78-A392A5A8ECCE");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44,
                column: "Vin",
                value: "BACAE821-9804-44C2-8D9B-70884DF8A310");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45,
                column: "Vin",
                value: "0310F749-8453-49FB-9AF0-2499194BF0B4");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46,
                column: "Vin",
                value: "36BF81C3-6E04-4B98-B9C1-1C98EA88CC4E");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47,
                column: "Vin",
                value: "4F091860-617B-41EB-9622-4146C9C5B3C0");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48,
                column: "Vin",
                value: "7CF1C25E-8217-485B-816B-16787719A5F9");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49,
                column: "Vin",
                value: "3356A89F-C26C-4477-A9CB-8A23CE66B924");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50,
                column: "Vin",
                value: "AF71B0ED-0CA8-4F48-A4B4-909259F9B933");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 51,
                column: "Vin",
                value: "F6E6F376-451D-42CC-8315-BE7D1B4B088F");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 52,
                column: "Vin",
                value: "70B98DE5-3476-469E-B49D-5883B6423B67");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 53,
                column: "Vin",
                value: "0496E683-8EB6-4B17-AD02-51EB5D98DED1");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 54,
                column: "Vin",
                value: "0ACC6E1B-4DF3-48E7-8C22-24B0EEFDCA8C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 55,
                column: "Vin",
                value: "02B5D061-841E-48D3-84DF-B689360F99A5");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 56,
                column: "Vin",
                value: "FCC10ED5-1A56-44E6-BA08-2E917561B298");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 57,
                column: "Vin",
                value: "F1020292-69B6-42D3-94F4-53B9C44CAE30");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 58,
                column: "Vin",
                value: "2A909E1E-06CD-43EF-92E4-9A1DC8155959");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 59,
                column: "Vin",
                value: "968FD5FA-B08E-4721-812D-88E1BD417137");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 60,
                column: "Vin",
                value: "578BCF41-DDCA-4C97-B787-7C9842BE8DF5");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 61,
                column: "Vin",
                value: "A00ACE7E-B28F-441D-A72E-CD09A8682437");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 62,
                column: "Vin",
                value: "BD942F2C-5BE0-474A-AB33-0D007ABB2AE8");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 63,
                column: "Vin",
                value: "14E71269-D02D-4FBD-A5C4-4430AABDA1E6");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 64,
                column: "Vin",
                value: "3D5CBAFC-5265-4507-B27D-76222A915468");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 65,
                column: "Vin",
                value: "5E626E7F-DB6B-4B47-B32F-0BB521F04DA8");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 66,
                column: "Vin",
                value: "5E4F9E89-DCE2-472D-9F64-B704D721953B");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 67,
                column: "Vin",
                value: "3699332D-85C2-462C-9335-90B4D9DA93FA");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 68,
                column: "Vin",
                value: "2D12DA97-830D-47CC-AD8B-82C3BF2814E0");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 69,
                column: "Vin",
                value: "D1852F21-17C4-45BE-A696-74A361D852EB");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 70,
                column: "Vin",
                value: "368E9A15-AA8D-44C2-A387-DF72405B6839");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 71,
                column: "Vin",
                value: "9D29C96F-F49F-44B6-B25B-CC89F7C8580C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 72,
                column: "Vin",
                value: "5C269FCC-CBBE-46D4-B6A3-9F6BEFAD1DED");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 73,
                column: "Vin",
                value: "D404669A-0111-474D-A264-D8254B574BAB");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 74,
                column: "Vin",
                value: "FC6625B8-49AB-40FB-BE27-038F6DF0C8CA");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 75,
                column: "Vin",
                value: "79BC8544-B1C9-4310-A75A-569AAD6E8DC9");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 76,
                column: "Vin",
                value: "61960486-7E43-40D9-8E6D-174F957E49B1");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 77,
                column: "Vin",
                value: "617D3902-0088-4F40-A099-47BAF83FA3EE");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 78,
                column: "Vin",
                value: "99058D51-A13B-42B0-997B-342F697CB9D7");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 79,
                column: "Vin",
                value: "7D8962BB-D2B1-4ECE-A928-9765894EE7F9");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 80,
                column: "Vin",
                value: "5F1B3A6C-D9F2-4D36-9038-2F5C4E703936");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 81,
                column: "Vin",
                value: "6F9DCDC0-319A-42D7-B7CD-14F9B02ABA16");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 82,
                column: "Vin",
                value: "BA2DC401-C7DB-4E89-B5F7-8E8FCF65317A");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 83,
                column: "Vin",
                value: "990996EA-9D5E-41C8-A7E9-6F1E77FFF464");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 84,
                column: "Vin",
                value: "847A808E-FA4E-435D-B713-39FD8D45ADB9");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 85,
                column: "Vin",
                value: "FC4826D4-5249-4708-84EE-A4B905CE48D5");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 86,
                column: "Vin",
                value: "9FE876DF-F32E-429F-8DD8-65DAE2BD59F4");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 87,
                column: "Vin",
                value: "39D97616-68D8-44CC-B062-CCDD668332CA");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 88,
                column: "Vin",
                value: "A40428ED-2718-43FD-91EC-E1063A4C4E48");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 89,
                column: "Vin",
                value: "61B1F52F-AE08-4775-AF78-88C96213DDB7");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 90,
                column: "Vin",
                value: "6B2F3225-0A18-48B8-9050-AFF54A57DBF9");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 91,
                column: "Vin",
                value: "C80DA99A-1B0C-4913-9F92-4ADB157C10D7");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 92,
                column: "Vin",
                value: "339E4A39-584D-4CEE-9A31-92A1B9E8C434");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 93,
                column: "Vin",
                value: "436A62E8-0C6A-4EE4-A34A-157AC480FB2D");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 94,
                column: "Vin",
                value: "D38C4BDC-BBD5-470F-A5D9-CBAD4E6FA8D3");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 95,
                column: "Vin",
                value: "5D0A2791-6B7C-405D-B454-1105499E97BF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 96,
                column: "Vin",
                value: "4627838D-DA94-42BC-8DD1-CE6EA94C45E0");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 97,
                column: "Vin",
                value: "A26FC50F-F53B-41E3-9C0A-1C7935AE2849");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 98,
                column: "Vin",
                value: "C62BC6DB-5BB3-4E2B-8295-B2941BB3B265");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 99,
                column: "Vin",
                value: "1D8E99BA-794F-4443-BE98-BFFBDFABD239");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 100,
                column: "Vin",
                value: "363A78C1-6286-4B46-B142-7502A6B8D446");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);
        }

        /// <inheritdoc />
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Vin",
                value: "5BC2BB04-6130-4063-8466-5698E6995DBC");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Vin",
                value: "3442AEC3-08E5-4FFD-A0F3-FE6E9B82C295");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Vin",
                value: "BF8597C3-8C37-4D15-BDC3-F41C85142639");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Vin",
                value: "0A65BD4E-3D5E-4684-8984-A0165765ED80");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Vin",
                value: "7EF403C9-D8D8-43BB-8A2A-2D8E4BA4DE6A");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Vin",
                value: "550B45E1-FC23-491B-A77F-66AB6EA12D5C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Vin",
                value: "422FB740-784C-4C55-9E90-553221F16EC7");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Vin",
                value: "EE599366-EE04-49A1-B876-70328153F6EC");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "Vin",
                value: "CB4FC223-4BE3-46D1-844F-9A1FE11484BA");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "Vin",
                value: "4A154645-4D68-45FC-B946-12890E8876DB");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "Vin",
                value: "1F6F8926-47D2-4809-A85C-C12E34FA7006");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "Vin",
                value: "8088E108-6B10-48D6-81CE-9F0A1D89DFAD");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "Vin",
                value: "C5EC9C5E-7DA5-438E-9571-5E66548999D2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "Vin",
                value: "112B44A3-73BF-43D1-92D4-A96D937B9000");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "Vin",
                value: "6E4914D1-1E3D-40F6-ACDA-CE68362E7BF5");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "Vin",
                value: "8BE56BA0-E3F3-4CC6-A7F3-B02F1997BFCF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "Vin",
                value: "7912244B-E5A7-4CFC-AECB-B0CF2A598C88");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "Vin",
                value: "46341A96-A278-41E4-BD2B-7837E2BB62FF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "Vin",
                value: "3D1BD3E1-7619-4884-B181-7B8C4FACF025");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "Vin",
                value: "119B4AB7-9EA5-4DFC-BFFB-971430467D0B");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "Vin",
                value: "2A02002E-96DE-4C11-9B69-C0AA8187FB37");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "Vin",
                value: "C2C09EF9-1280-4573-A026-5056F123FF89");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "Vin",
                value: "60D83FBE-7712-423C-B99E-1A7B253970F5");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "Vin",
                value: "0B732C49-8FE8-42A6-BCAF-33659EF7FD61");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "Vin",
                value: "02B1E16D-2A5A-4F48-8820-6CEEDF86F99D");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "Vin",
                value: "F3777647-D6CE-40CE-90D3-21189B61AB0A");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "Vin",
                value: "F625ABDD-12A5-4E5C-BB1F-91AD84B5DD63");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "Vin",
                value: "92C7B501-CE39-4ADD-A337-B2E7DD542F5D");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "Vin",
                value: "A4751A7B-C9D6-4957-A7CD-B42B97F04FCA");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                column: "Vin",
                value: "5C4E9E4C-B56C-4E02-9613-FBEFC89B0E5B");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                column: "Vin",
                value: "B98523E8-BE1C-45F0-A882-AB62374C49E0");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                column: "Vin",
                value: "72FACFF4-F4A4-43C1-B28C-0E6A71070A87");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                column: "Vin",
                value: "7BAC7A78-CCBA-48C9-B2F3-DF33EAF1F624");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34,
                column: "Vin",
                value: "BEC48681-865A-4B0B-8426-6E685678C726");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35,
                column: "Vin",
                value: "C60387AF-6263-4CB4-AC52-61A446111319");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36,
                column: "Vin",
                value: "6E602BBC-9484-4FC9-A109-071EDB6B505D");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37,
                column: "Vin",
                value: "1937651F-4F06-4A02-8359-D70EB1D7B918");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38,
                column: "Vin",
                value: "D291A402-975D-478E-A969-6FD3C7DE5D46");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39,
                column: "Vin",
                value: "B3205CA7-58D9-46AA-B0E7-7B93632B0415");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40,
                column: "Vin",
                value: "17AE704B-96E9-4D23-B85E-E0F7A0A9B441");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41,
                column: "Vin",
                value: "650C814F-822A-4FE9-B7C6-316AB70E4538");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42,
                column: "Vin",
                value: "9818539F-8C03-4004-9516-5C455E8ADAF2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43,
                column: "Vin",
                value: "8A2C8948-F87E-493F-84F8-0094DFA484CD");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44,
                column: "Vin",
                value: "179612A1-B286-4629-8610-6ACC2CE31A3F");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45,
                column: "Vin",
                value: "69EF8B43-EA47-4C5A-BE43-43E21D8765BA");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46,
                column: "Vin",
                value: "DEA90426-07D8-4EEC-851D-BF6730C07728");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47,
                column: "Vin",
                value: "1E952196-89CE-48BC-A29C-79F59B494AB4");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48,
                column: "Vin",
                value: "D50D5CC9-0F7C-4FC4-89D2-0F8CB8D5ED1B");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49,
                column: "Vin",
                value: "712BBDA6-628A-4C91-B560-AA55B408B018");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50,
                column: "Vin",
                value: "5AD3AA2F-F9DF-4CC3-8F91-88598B11A6C1");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 51,
                column: "Vin",
                value: "EB15119A-E2C1-464A-B159-B10C51D5E3C7");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 52,
                column: "Vin",
                value: "0CBF30F1-5910-491F-8DF5-FEA6FEE2C6F1");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 53,
                column: "Vin",
                value: "79BC21C0-7850-41CB-A26A-1834660392FE");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 54,
                column: "Vin",
                value: "B19FB9EF-E491-413E-897C-60263F5253F8");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 55,
                column: "Vin",
                value: "900F12BE-6374-482F-8E77-3200B2EBF263");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 56,
                column: "Vin",
                value: "6D9EABCF-118B-44D5-B2ED-60754EBE30C6");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 57,
                column: "Vin",
                value: "42380B4C-FAC4-4808-AFCF-BD7511059AC5");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 58,
                column: "Vin",
                value: "E81708A1-F97D-42B9-A150-60445BA40DD2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 59,
                column: "Vin",
                value: "A4107172-32CD-4E5C-BAD4-324182EDDE2A");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 60,
                column: "Vin",
                value: "0137EC99-EF7D-4E79-AD54-991B5DF42E6D");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 61,
                column: "Vin",
                value: "64BE24A9-EAB8-4C60-8398-0785400C4287");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 62,
                column: "Vin",
                value: "ABBDAC23-9F7F-4445-87D1-F2CD59C3AF73");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 63,
                column: "Vin",
                value: "F4CB0830-9242-4419-854B-ED60C27D1AD3");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 64,
                column: "Vin",
                value: "B7440982-2F9D-475E-BFC8-4A463248895F");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 65,
                column: "Vin",
                value: "24E61148-34DF-41A0-A141-5E297B2DC432");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 66,
                column: "Vin",
                value: "934037F9-15FD-47C2-AA70-204729A7BBB3");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 67,
                column: "Vin",
                value: "F26CA966-BE8D-4417-BCD2-ED192FF295E1");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 68,
                column: "Vin",
                value: "6FDBD1D8-1CDA-4A8F-A99F-6466A08AD276");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 69,
                column: "Vin",
                value: "0CD9DF06-DB7E-4FFA-A874-4FF220C4E2C0");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 70,
                column: "Vin",
                value: "17F6C7C2-A1B1-46E8-B0CA-4322191F02BF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 71,
                column: "Vin",
                value: "CAEA0437-2F69-4095-B89A-29DF82C4095A");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 72,
                column: "Vin",
                value: "F7886A8F-2CCB-4CAA-910A-4F754E522F77");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 73,
                column: "Vin",
                value: "6F9313CF-E274-4621-A294-21FDAE78F2AF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 74,
                column: "Vin",
                value: "40BA7B2B-2F34-49E8-A6EF-043B8C4FA9F7");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 75,
                column: "Vin",
                value: "68DA8B20-4AA8-48CA-A60A-0DF7CC97ACCF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 76,
                column: "Vin",
                value: "C74D8741-1C08-498F-B277-7FB239C1A412");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 77,
                column: "Vin",
                value: "6923792F-F129-43BD-8322-64659D73D98E");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 78,
                column: "Vin",
                value: "3546B542-B947-4529-A9B1-A72CE8AA2733");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 79,
                column: "Vin",
                value: "B27A1244-3B27-4C64-9E9B-233CAEA8FD51");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 80,
                column: "Vin",
                value: "E21D8325-5079-4702-B341-46E5E2C062D9");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 81,
                column: "Vin",
                value: "98DA9CA0-684E-4B3D-A623-0CA145824C78");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 82,
                column: "Vin",
                value: "BE42535A-8333-4C1B-BF18-5DF245B12777");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 83,
                column: "Vin",
                value: "D7D918C1-A729-4CB0-829C-C3C1CEE367A2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 84,
                column: "Vin",
                value: "52302A28-889E-4603-9DCD-BCABC2C5B53F");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 85,
                column: "Vin",
                value: "7BC93997-91B0-442A-8292-E8D5778A63D7");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 86,
                column: "Vin",
                value: "727B2E39-7C24-44A0-956C-B583A0C88076");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 87,
                column: "Vin",
                value: "F1B9AF3E-F011-41CD-9467-321E7713CC2C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 88,
                column: "Vin",
                value: "D6846ED3-CE6C-4D2E-B605-24AFA110C737");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 89,
                column: "Vin",
                value: "FA4CAED1-27C5-4B54-8015-E70E34C8CA4A");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 90,
                column: "Vin",
                value: "BBEB6EE0-155F-4713-A3C4-3B0416763800");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 91,
                column: "Vin",
                value: "1757DC1E-AA8D-4D35-97DA-6CA2A8D60FDF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 92,
                column: "Vin",
                value: "A0D5BC73-F443-4514-AA8A-346A0E2EA551");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 93,
                column: "Vin",
                value: "FE52C1DF-7CAE-411D-8230-61D2255CF194");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 94,
                column: "Vin",
                value: "43377088-3E0F-4E5B-B7C6-9818DA001977");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 95,
                column: "Vin",
                value: "5AE2E400-0763-45A9-98C0-C2057D71B683");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 96,
                column: "Vin",
                value: "3F5CBF32-55B6-46E4-90F6-FFA9CBC25E59");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 97,
                column: "Vin",
                value: "81BD5C6F-7571-4E50-9C3E-01EDFF799368");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 98,
                column: "Vin",
                value: "88C305D0-2FED-4DF4-B39A-3A03E8B195C9");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 99,
                column: "Vin",
                value: "0C751606-522F-461A-9CC6-FFB029D694E8");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 100,
                column: "Vin",
                value: "51CEE71D-1AA7-465C-A004-4047AA01FBE3");
        }
    }
}
