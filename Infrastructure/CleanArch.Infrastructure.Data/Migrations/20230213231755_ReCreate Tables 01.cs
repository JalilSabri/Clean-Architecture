using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArch.Infrastructure.Data.Migrations
{
    public partial class ReCreateTables01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblOrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatusTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPersons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPersons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblProducts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Varienty = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblCustomers",
                columns: table => new
                {
                    CustomerPersonId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCustomers_tblPersons_CustomerPersonId",
                        column: x => x.CustomerPersonId,
                        principalTable: "tblPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblSalesPersons",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    City = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    State = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSalesPersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblSalesPersons_tblPersons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "tblPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblOrders",
                columns: table => new
                {
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SalesPerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    salesPersonId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrderStatusId = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblOrders_tblCustomers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "tblCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOrders_tblOrderStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "tblOrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOrders_tblSalesPersons_salesPersonId",
                        column: x => x.salesPersonId,
                        principalTable: "tblSalesPersons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tblOrderItems",
                columns: table => new
                {
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    ordersId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    productsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblOrderItems_tblOrders_ordersId",
                        column: x => x.ordersId,
                        principalTable: "tblOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tblOrderItems_tblProducts_productsId",
                        column: x => x.productsId,
                        principalTable: "tblProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomers_CustomerPersonId",
                table: "tblCustomers",
                column: "CustomerPersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderItems_ordersId",
                table: "tblOrderItems",
                column: "ordersId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrderItems_productsId",
                table: "tblOrderItems",
                column: "productsId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrders_CustomerId",
                table: "tblOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrders_OrderStatusId",
                table: "tblOrders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOrders_salesPersonId",
                table: "tblOrders",
                column: "salesPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSalesPersons_PersonId",
                table: "tblSalesPersons",
                column: "PersonId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblOrderItems");

            migrationBuilder.DropTable(
                name: "tblOrders");

            migrationBuilder.DropTable(
                name: "tblProducts");

            migrationBuilder.DropTable(
                name: "tblCustomers");

            migrationBuilder.DropTable(
                name: "tblOrderStatus");

            migrationBuilder.DropTable(
                name: "tblSalesPersons");

            migrationBuilder.DropTable(
                name: "tblPersons");
        }
    }
}
