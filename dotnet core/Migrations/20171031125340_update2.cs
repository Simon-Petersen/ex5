using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace dotnet_core.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentTypes_ComponentTypeId",
                table: "Components");

            migrationBuilder.DropForeignKey(
                name: "FK_ComponentTypes_EsImages_ImageESImageId",
                table: "ComponentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_tableJoin_Categories_CategoryId",
                table: "tableJoin");

            migrationBuilder.DropForeignKey(
                name: "FK_tableJoin_ComponentTypes_ComponentTypeId",
                table: "tableJoin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EsImages",
                table: "EsImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComponentTypes",
                table: "ComponentTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Components",
                table: "Components");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "EsImages",
                newName: "EsImage");

            migrationBuilder.RenameTable(
                name: "ComponentTypes",
                newName: "ComponentType");

            migrationBuilder.RenameTable(
                name: "Components",
                newName: "Component");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_ComponentTypes_ImageESImageId",
                table: "ComponentType",
                newName: "IX_ComponentType_ImageESImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Components_ComponentTypeId",
                table: "Component",
                newName: "IX_Component_ComponentTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EsImage",
                table: "EsImage",
                column: "ESImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComponentType",
                table: "ComponentType",
                column: "ComponentTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Component",
                table: "Component",
                column: "ComponentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Component_ComponentType_ComponentTypeId",
                table: "Component",
                column: "ComponentTypeId",
                principalTable: "ComponentType",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentType_EsImage_ImageESImageId",
                table: "ComponentType",
                column: "ImageESImageId",
                principalTable: "EsImage",
                principalColumn: "ESImageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tableJoin_Category_CategoryId",
                table: "tableJoin",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tableJoin_ComponentType_ComponentTypeId",
                table: "tableJoin",
                column: "ComponentTypeId",
                principalTable: "ComponentType",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Component_ComponentType_ComponentTypeId",
                table: "Component");

            migrationBuilder.DropForeignKey(
                name: "FK_ComponentType_EsImage_ImageESImageId",
                table: "ComponentType");

            migrationBuilder.DropForeignKey(
                name: "FK_tableJoin_Category_CategoryId",
                table: "tableJoin");

            migrationBuilder.DropForeignKey(
                name: "FK_tableJoin_ComponentType_ComponentTypeId",
                table: "tableJoin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EsImage",
                table: "EsImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComponentType",
                table: "ComponentType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Component",
                table: "Component");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "EsImage",
                newName: "EsImages");

            migrationBuilder.RenameTable(
                name: "ComponentType",
                newName: "ComponentTypes");

            migrationBuilder.RenameTable(
                name: "Component",
                newName: "Components");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_ComponentType_ImageESImageId",
                table: "ComponentTypes",
                newName: "IX_ComponentTypes_ImageESImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Component_ComponentTypeId",
                table: "Components",
                newName: "IX_Components_ComponentTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EsImages",
                table: "EsImages",
                column: "ESImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComponentTypes",
                table: "ComponentTypes",
                column: "ComponentTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Components",
                table: "Components",
                column: "ComponentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentTypes_ComponentTypeId",
                table: "Components",
                column: "ComponentTypeId",
                principalTable: "ComponentTypes",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentTypes_EsImages_ImageESImageId",
                table: "ComponentTypes",
                column: "ImageESImageId",
                principalTable: "EsImages",
                principalColumn: "ESImageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tableJoin_Categories_CategoryId",
                table: "tableJoin",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tableJoin_ComponentTypes_ComponentTypeId",
                table: "tableJoin",
                column: "ComponentTypeId",
                principalTable: "ComponentTypes",
                principalColumn: "ComponentTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
