using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TourApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Costs",
                columns: table => new
                {
                    CostId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CostName = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costs", x => x.CostId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(nullable: true),
                    IdentityCardNumber = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LocationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(nullable: true),
                    IdentityCardNumber = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    JobId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JobName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "TourPrice",
                columns: table => new
                {
                    TourPriceId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourPrice", x => x.TourPriceId);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfTourism",
                columns: table => new
                {
                    TypesOfTourismId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfTourism", x => x.TypesOfTourismId);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HotelName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                    table.ForeignKey(
                        name: "FK_Hotels_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DutyId = table.Column<int>(nullable: false),
                    StaffId = table.Column<int>(nullable: false),
                    JobId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskDetails_Task_JobId",
                        column: x => x.JobId,
                        principalTable: "Task",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskDetails_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TourName = table.Column<string>(nullable: true),
                    TourCharacteristics = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: false),
                    TourPriceId = table.Column<int>(nullable: false),
                    TypesOfTourismId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_Tours_TourPrice_TourPriceId",
                        column: x => x.TourPriceId,
                        principalTable: "TourPrice",
                        principalColumn: "TourPriceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tours_TypesOfTourism_TypesOfTourismId",
                        column: x => x.TypesOfTourismId,
                        principalTable: "TypesOfTourism",
                        principalColumn: "TypesOfTourismId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TourDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TourId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourDetails_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourDetails_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourDetailsOfCustomer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<int>(nullable: false),
                    TourId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourDetailsOfCustomer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourDetailsOfCustomer_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourDetailsOfCustomer_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourDetailsOfStaff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StaffId = table.Column<int>(nullable: false),
                    TourId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourDetailsOfStaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourDetailsOfStaff_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourDetailsOfStaff_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TouristGroup",
                columns: table => new
                {
                    TouristGroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: true),
                    NumberOfMembers = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    TourId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TouristGroup", x => x.TouristGroupId);
                    table.ForeignKey(
                        name: "FK_TouristGroup_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CostDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TouristGroupId = table.Column<int>(nullable: false),
                    CostId = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostDetails_Costs_CostId",
                        column: x => x.CostId,
                        principalTable: "Costs",
                        principalColumn: "CostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CostDetails_TouristGroup_TouristGroupId",
                        column: x => x.TouristGroupId,
                        principalTable: "TouristGroup",
                        principalColumn: "TouristGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CostDetails_CostId",
                table: "CostDetails",
                column: "CostId");

            migrationBuilder.CreateIndex(
                name: "IX_CostDetails_TouristGroupId",
                table: "CostDetails",
                column: "TouristGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_LocationId",
                table: "Hotels",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDetails_JobId",
                table: "TaskDetails",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDetails_StaffId",
                table: "TaskDetails",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDetails_LocationId",
                table: "TourDetails",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDetails_TourId",
                table: "TourDetails",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDetailsOfCustomer_CustomerId",
                table: "TourDetailsOfCustomer",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDetailsOfCustomer_TourId",
                table: "TourDetailsOfCustomer",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDetailsOfStaff_StaffId",
                table: "TourDetailsOfStaff",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDetailsOfStaff_TourId",
                table: "TourDetailsOfStaff",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TouristGroup_TourId",
                table: "TouristGroup",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TourPriceId",
                table: "Tours",
                column: "TourPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TypesOfTourismId",
                table: "Tours",
                column: "TypesOfTourismId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostDetails");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "TaskDetails");

            migrationBuilder.DropTable(
                name: "TourDetails");

            migrationBuilder.DropTable(
                name: "TourDetailsOfCustomer");

            migrationBuilder.DropTable(
                name: "TourDetailsOfStaff");

            migrationBuilder.DropTable(
                name: "Costs");

            migrationBuilder.DropTable(
                name: "TouristGroup");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "TourPrice");

            migrationBuilder.DropTable(
                name: "TypesOfTourism");
        }
    }
}
