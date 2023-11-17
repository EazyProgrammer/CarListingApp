using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarListingApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "55aa28a3-b506-45a9-aac1-e3093a894f5c", "c00e884f-15d2-4eca-8a20-390badf1857c", "User", "USER" },
                    { "c82225b5-020c-48de-beef-c2fc0b14b62f", "0ebf9642-4ad4-4d5d-8c01-762a23f979aa", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06bde6ec-53ef-4899-8f70-448dfde1061d", 0, "079b40a5-2387-4d2d-ab25-5b13bd98708a", "administrator@localhost.com", true, false, null, "ADMINISTRATOR@LOCALHOST.COM", "ADMINISTRATOR@LOCALHOST.COM", "AQAAAAIAAYagAAAAELyZexhRRSKjyvCKLeuWTQ/mZQY7JbvwKtstikuDevJLMUieNjm54XL4doiYCgmtnQ==", null, false, "88b35dfb-7b49-4bf9-b02a-69473bc09a00", false, "administrator@localhost.com" },
                    { "f3f82840-4505-403e-9679-db20a2f9db8b", 0, "00a97e9c-f7e0-49c3-b17b-455470228ce2", "user@localhost.com", true, false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFba92FyurbS1ODhX9CuWfdnT30e9L0R8Y93UarUY3KdKC0bTLNClAAZ7t6YR63rpw==", null, false, "880288fe-0358-4ed8-93d4-a49e41a9f415", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Vin",
                value: "E5C30D90-162F-4F87-B9D7-2D2DACBE3D15");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Vin",
                value: "897614D7-FD9E-480C-B153-F375A6046773");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Vin",
                value: "8DF1424C-6C4F-4893-8C31-343BF7C06162");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Vin",
                value: "10E83C15-6B5B-4DB0-9261-5065DCDF97C2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Vin",
                value: "6CDC04A2-AB95-4008-91C8-28645774F2A2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Vin",
                value: "E528FABA-3086-4386-AC2D-D01CF2D77575");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Vin",
                value: "7015C55C-3BB6-482B-95A9-F045DA03BDA7");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Vin",
                value: "6F860AAE-53FD-415B-9D3D-F54004B91764");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "Vin",
                value: "30E37ACC-BAEC-47FD-AD82-1B293B86D2A1");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "Vin",
                value: "9A7C59BD-227B-4376-BEA1-7F51510AEDB4");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "Vin",
                value: "2B61AFA6-1696-46E2-8F1F-F065D7CD01B0");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "Vin",
                value: "A72859A5-9124-4275-82A3-71A15DBB5EB9");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "Vin",
                value: "66FD9E0B-B305-422A-AF57-F3843E111DF5");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "Vin",
                value: "C91AC291-B8DD-4AA9-87FB-AFEE8AAFDA5A");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "Vin",
                value: "8D81AB6F-6692-4E7C-83E7-A2B64B5CFF9B");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "Vin",
                value: "B44877A8-ED35-4095-A178-2915C16D4B7E");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "Vin",
                value: "2C098D9D-1541-400D-89F1-C98B14295C0C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "Vin",
                value: "190050AD-1FF4-4874-B0EB-6DD2914E1078");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "Vin",
                value: "7C5399B8-1924-4BFC-82F0-6476A85A8222");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "Vin",
                value: "607CCB0E-84EC-4AC4-9A6B-E2B97193291D");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "Vin",
                value: "26F8498F-881E-41AC-93E3-D545747C1631");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "Vin",
                value: "5AA8794C-AF02-48A9-9D3A-0F41A1303443");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "Vin",
                value: "47854390-6CB6-4D51-B34D-158483061AD4");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "Vin",
                value: "FB984363-7CAA-4E18-ABF2-3D2133403984");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "Vin",
                value: "2DF867C6-D2A4-4403-A9BE-7A7B8F53E07C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "Vin",
                value: "1DAAEDEC-1D82-4AC0-8AD8-3C45C92DA0F1");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "Vin",
                value: "61AE3323-F225-4658-A21B-4D44EBF01B0F");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "Vin",
                value: "FDD1A8F4-CB54-4B7E-BE08-852D8F4A5BDA");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "Vin",
                value: "F3C6894A-8529-4BAE-9351-3A61BDE7F420");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                column: "Vin",
                value: "E756A680-CE67-408C-A70B-04A033F5AEC5");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                column: "Vin",
                value: "2F919450-51C0-4677-8792-E9B15AA9D55F");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                column: "Vin",
                value: "A2C4AD18-FB47-499B-9D19-6FD03F5718EF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                column: "Vin",
                value: "E5B90E84-22A6-45E8-AA31-8EF736E967AD");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34,
                column: "Vin",
                value: "5ED4253F-BB18-41AF-A9BF-E3033847D6BB");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35,
                column: "Vin",
                value: "568DA3E1-B7A2-436D-AEE5-9B5024E08479");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36,
                column: "Vin",
                value: "BBCC76AC-0591-4115-8ABC-490912FF9A15");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37,
                column: "Vin",
                value: "BF3BA832-FEF3-4280-A48F-FD3671CDA7DE");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38,
                column: "Vin",
                value: "6D0B077B-F692-44E1-9963-F53BEB4EAC2D");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39,
                column: "Vin",
                value: "F73D43B6-2F2A-4906-838B-C89D7D32A98D");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40,
                column: "Vin",
                value: "7F4F3095-4AB2-46F2-8198-B193970EA138");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41,
                column: "Vin",
                value: "F5CC5DE6-1087-4724-9ECE-6D2401415D9C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42,
                column: "Vin",
                value: "A0741EE5-D19A-492E-8502-02B1DC0BDDA2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43,
                column: "Vin",
                value: "CC224B6E-BC60-455E-939C-A889C1117CAF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44,
                column: "Vin",
                value: "B4DA6469-38A5-4E4E-81EF-714F901A8A23");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45,
                column: "Vin",
                value: "482A1D08-EA13-48E4-9089-7CC2304A6203");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46,
                column: "Vin",
                value: "D84CB03D-9E13-4159-BA55-4ECF7D0B71B3");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47,
                column: "Vin",
                value: "2E57BCEE-C916-4C33-AB34-C17F1E8E3D06");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48,
                column: "Vin",
                value: "63F3672A-C76E-414C-A9B7-D412DC5C385F");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49,
                column: "Vin",
                value: "80DEFA4A-075E-4E67-B20A-340D293192AF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50,
                column: "Vin",
                value: "39831621-9D7B-401D-83C1-AA152D20F416");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 51,
                column: "Vin",
                value: "A37CF695-1DB4-4F61-A44B-8286B9AE66DE");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 52,
                column: "Vin",
                value: "AF167A7D-9C77-4CFB-8A59-B684F4765FA6");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 53,
                column: "Vin",
                value: "29E6DD31-F606-4811-AA0A-D5871ECC8202");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 54,
                column: "Vin",
                value: "D57A56D1-434A-4C11-BCBB-E50B0AFB41FC");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 55,
                column: "Vin",
                value: "01F4EB29-076C-498F-A69D-9E25A849C6AB");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 56,
                column: "Vin",
                value: "16B9B5D2-D5E6-4A81-AEB5-6560F79C41F5");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 57,
                column: "Vin",
                value: "5E359962-8733-4C3D-8313-74FECC60668D");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 58,
                column: "Vin",
                value: "C7142B5D-1BA3-4389-91A0-C8A15E192428");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 59,
                column: "Vin",
                value: "F9F8E937-4F4F-4061-B59B-6E73ABE7017B");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 60,
                column: "Vin",
                value: "445B967E-5F7C-42C6-9075-02BB98752FBD");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 61,
                column: "Vin",
                value: "89060E81-9E38-4F43-9508-64487A33DE8C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 62,
                column: "Vin",
                value: "FD0EB26E-BAA8-4095-816C-2171F1ACA438");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 63,
                column: "Vin",
                value: "AF76FD9E-07E1-4AB8-9AB9-2CE1FBD86973");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 64,
                column: "Vin",
                value: "56FB164A-D9F5-4A94-A2C0-ABA65EEC4F0C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 65,
                column: "Vin",
                value: "C3B17B0C-97F6-4C5F-9B3D-120E95B4A8EF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 66,
                column: "Vin",
                value: "BDA655B7-A760-4158-B61D-7AF10D2A4469");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 67,
                column: "Vin",
                value: "BFECF2BD-1304-4778-80B7-884CF6A7CDAB");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 68,
                column: "Vin",
                value: "E5948F40-932B-4D13-9989-22BEC448E37C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 69,
                column: "Vin",
                value: "E89A58C6-FB18-4C33-A2A2-CB64B972C87A");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 70,
                column: "Vin",
                value: "C28750B7-4ECB-4252-A0DD-5156DBFB218E");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 71,
                column: "Vin",
                value: "6FF24285-3A28-4F13-BF37-400D0FE27721");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 72,
                column: "Vin",
                value: "6DC413A7-D29E-45A4-9504-C941D85980DC");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 73,
                column: "Vin",
                value: "42843406-8811-4743-8C98-8F7A23502616");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 74,
                column: "Vin",
                value: "E8E98B60-65FF-4C23-BA52-9D69C1924213");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 75,
                column: "Vin",
                value: "56D3515D-C381-4313-B6B5-5769C78C921F");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 76,
                column: "Vin",
                value: "1CF10343-AD73-4C64-8940-B9C98DAC1D28");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 77,
                column: "Vin",
                value: "B7AAD306-72A4-4493-90A9-AE41DCFB7F4E");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 78,
                column: "Vin",
                value: "B798EB76-2E05-4E47-A8C0-77E592074143");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 79,
                column: "Vin",
                value: "68696E37-E81F-4C1C-AC1F-C218A8FDEBAE");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 80,
                column: "Vin",
                value: "606EF72C-B256-49C1-8E0B-A2C691A234B3");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 81,
                column: "Vin",
                value: "25DF56CA-282A-4301-86BA-156603E21399");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 82,
                column: "Vin",
                value: "CE794AC9-07F1-4D1D-B047-BDB97E4D845F");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 83,
                column: "Vin",
                value: "BC797A3B-43FB-42F8-8BD4-1CCC775620AF");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 84,
                column: "Vin",
                value: "F1BFAD43-B2B7-442A-B0D4-DA28BDFEA39D");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 85,
                column: "Vin",
                value: "345F33D6-45C8-445C-BBF0-9B7491E6BF02");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 86,
                column: "Vin",
                value: "9B0B00C6-B231-42D5-BEFA-FA5B6672F9E1");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 87,
                column: "Vin",
                value: "2F29A7F3-87D4-4343-8FF0-F308E782C333");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 88,
                column: "Vin",
                value: "76F72F62-F19A-463B-B1A1-1A8F818DD83C");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 89,
                column: "Vin",
                value: "24BCAB44-65E0-481E-9BBB-6F3906374898");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 90,
                column: "Vin",
                value: "2C21A898-21DC-4928-A786-944ED17C1827");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 91,
                column: "Vin",
                value: "EBED270F-8164-4200-9431-332C17241728");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 92,
                column: "Vin",
                value: "B704C8F6-A4A3-44B0-B274-54CA1DF67CB8");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 93,
                column: "Vin",
                value: "CEBE61FA-285A-490A-8D81-72D7F960B368");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 94,
                column: "Vin",
                value: "0A6D3BE9-3673-4E7A-9A56-EFA9ADFF5FE8");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 95,
                column: "Vin",
                value: "4343BC1F-391B-4A4E-9DAF-405A6F34C375");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 96,
                column: "Vin",
                value: "10460E42-8B1C-48E6-86AC-BA18BEE1584E");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 97,
                column: "Vin",
                value: "FE2C7AB9-9354-49D9-A0F9-B0A5B3F0A76D");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 98,
                column: "Vin",
                value: "46589AB6-E4AA-4B0B-B0D3-C6D46D543899");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 99,
                column: "Vin",
                value: "E18FE7A8-6FD9-4228-A1A2-059A26A89C26");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 100,
                column: "Vin",
                value: "CF295F9D-B982-41E7-B57A-98F6E140B470");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c82225b5-020c-48de-beef-c2fc0b14b62f", "06bde6ec-53ef-4899-8f70-448dfde1061d" },
                    { "55aa28a3-b506-45a9-aac1-e3093a894f5c", "f3f82840-4505-403e-9679-db20a2f9db8b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c82225b5-020c-48de-beef-c2fc0b14b62f", "06bde6ec-53ef-4899-8f70-448dfde1061d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "55aa28a3-b506-45a9-aac1-e3093a894f5c", "f3f82840-4505-403e-9679-db20a2f9db8b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55aa28a3-b506-45a9-aac1-e3093a894f5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c82225b5-020c-48de-beef-c2fc0b14b62f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06bde6ec-53ef-4899-8f70-448dfde1061d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3f82840-4505-403e-9679-db20a2f9db8b");

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
        }
    }
}
