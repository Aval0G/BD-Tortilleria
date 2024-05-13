using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TDB.Migrations
{
    /// <inheritdoc />
    public partial class Inventario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdProveedor",
                table: "Proveedores_Producto",
                newName: "ProveedorID");

            migrationBuilder.RenameColumn(
                name: "IdProducto",
                table: "Proveedores_Producto",
                newName: "ProductoId");

            migrationBuilder.RenameColumn(
                name: "IdProducto",
                table: "Inventario",
                newName: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_Producto_ProductoId",
                table: "Proveedores_Producto",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_Producto_ProveedorID",
                table: "Proveedores_Producto",
                column: "ProveedorID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_ProductoId",
                table: "Inventario",
                column: "ProductoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventario_Producto_ProductoId",
                table: "Inventario",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedores_Producto_Producto_ProductoId",
                table: "Proveedores_Producto",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedores_Producto_Proveedores_ProveedorID",
                table: "Proveedores_Producto",
                column: "ProveedorID",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventario_Producto_ProductoId",
                table: "Inventario");

            migrationBuilder.DropForeignKey(
                name: "FK_Proveedores_Producto_Producto_ProductoId",
                table: "Proveedores_Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Proveedores_Producto_Proveedores_ProveedorID",
                table: "Proveedores_Producto");

            migrationBuilder.DropIndex(
                name: "IX_Proveedores_Producto_ProductoId",
                table: "Proveedores_Producto");

            migrationBuilder.DropIndex(
                name: "IX_Proveedores_Producto_ProveedorID",
                table: "Proveedores_Producto");

            migrationBuilder.DropIndex(
                name: "IX_Inventario_ProductoId",
                table: "Inventario");

            migrationBuilder.RenameColumn(
                name: "ProveedorID",
                table: "Proveedores_Producto",
                newName: "IdProveedor");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "Proveedores_Producto",
                newName: "IdProducto");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "Inventario",
                newName: "IdProducto");
        }
    }
}
