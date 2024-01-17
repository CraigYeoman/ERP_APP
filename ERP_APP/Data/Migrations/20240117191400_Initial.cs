using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_APP.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "BaseEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobType_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Labor_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LaborCategoryId = table.Column<int>(type: "int", nullable: true),
                    LaborCategory_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Part_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    CustomerPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CostOfGood = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PartNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartCategoryId = table.Column<int>(type: "int", nullable: true),
                    PartCategory_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deposit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WorkOrderId = table.Column<int>(type: "int", nullable: true),
                    Vendor_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vendor_PhoneNumber = table.Column<int>(type: "int", nullable: true),
                    Vendor_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vendor_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vendor_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vendor_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vendor_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    JobTypeId = table.Column<int>(type: "int", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateReceived = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateFinished = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Complete = table.Column<bool>(type: "bit", nullable: true),
                    WorkOrderNumber = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkOrderAccessories_WorkOrderId = table.Column<int>(type: "int", nullable: true),
                    AccessoriesId = table.Column<int>(type: "int", nullable: true),
                    WorkOrderLabor_WorkOrderId = table.Column<int>(type: "int", nullable: true),
                    LaborId = table.Column<int>(type: "int", nullable: true),
                    WorkOrderPart_WorkOrderId = table.Column<int>(type: "int", nullable: true),
                    PartId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_AccessoriesId",
                        column: x => x.AccessoriesId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_LaborCategoryId",
                        column: x => x.LaborCategoryId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_LaborId",
                        column: x => x.LaborId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_PartCategoryId",
                        column: x => x.PartCategoryId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_PartId",
                        column: x => x.PartId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_VendorId",
                        column: x => x.VendorId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_WorkOrderAccessories_WorkOrderId",
                        column: x => x.WorkOrderAccessories_WorkOrderId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_WorkOrderId",
                        column: x => x.WorkOrderId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_WorkOrderLabor_WorkOrderId",
                        column: x => x.WorkOrderLabor_WorkOrderId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_WorkOrderPart_WorkOrderId",
                        column: x => x.WorkOrderPart_WorkOrderId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_AccessoriesId",
                table: "BaseEntities",
                column: "AccessoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_CustomerId",
                table: "BaseEntities",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_JobTypeId",
                table: "BaseEntities",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_LaborCategoryId",
                table: "BaseEntities",
                column: "LaborCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_LaborId",
                table: "BaseEntities",
                column: "LaborId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_PartCategoryId",
                table: "BaseEntities",
                column: "PartCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_PartId",
                table: "BaseEntities",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_VendorId",
                table: "BaseEntities",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_WorkOrderAccessories_WorkOrderId",
                table: "BaseEntities",
                column: "WorkOrderAccessories_WorkOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_WorkOrderId",
                table: "BaseEntities",
                column: "WorkOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_WorkOrderLabor_WorkOrderId",
                table: "BaseEntities",
                column: "WorkOrderLabor_WorkOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_WorkOrderPart_WorkOrderId",
                table: "BaseEntities",
                column: "WorkOrderPart_WorkOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntities");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
