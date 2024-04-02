using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusRoutesManager.Domain.Migrations
{
    /// <inheritdoc />
    public partial class TicketTakenFromBusStationsAndConnectedToRouteNodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_BusStations_ArrivalStationId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_BusStations_DepartureStationId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "DepartureStationId",
                table: "Tickets",
                newName: "DepartureRouteNodeId");

            migrationBuilder.RenameColumn(
                name: "ArrivalStationId",
                table: "Tickets",
                newName: "ArrivalRouteNodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_DepartureStationId",
                table: "Tickets",
                newName: "IX_Tickets_DepartureRouteNodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ArrivalStationId",
                table: "Tickets",
                newName: "IX_Tickets_ArrivalRouteNodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_RouteNodes_ArrivalRouteNodeId",
                table: "Tickets",
                column: "ArrivalRouteNodeId",
                principalTable: "RouteNodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_RouteNodes_DepartureRouteNodeId",
                table: "Tickets",
                column: "DepartureRouteNodeId",
                principalTable: "RouteNodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_RouteNodes_ArrivalRouteNodeId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_RouteNodes_DepartureRouteNodeId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "DepartureRouteNodeId",
                table: "Tickets",
                newName: "DepartureStationId");

            migrationBuilder.RenameColumn(
                name: "ArrivalRouteNodeId",
                table: "Tickets",
                newName: "ArrivalStationId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_DepartureRouteNodeId",
                table: "Tickets",
                newName: "IX_Tickets_DepartureStationId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ArrivalRouteNodeId",
                table: "Tickets",
                newName: "IX_Tickets_ArrivalStationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_BusStations_ArrivalStationId",
                table: "Tickets",
                column: "ArrivalStationId",
                principalTable: "BusStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_BusStations_DepartureStationId",
                table: "Tickets",
                column: "DepartureStationId",
                principalTable: "BusStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
