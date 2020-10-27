﻿namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Autors", newName: "Autor");
            RenameTable(name: "dbo.Livroes", newName: "Livro");
            RenameTable(name: "dbo.Categorias", newName: "Categoria");
            RenameTable(name: "dbo.LivroAutors", newName: "LivroAutor");
            DropPrimaryKey("dbo.LivroAutor");
            AddPrimaryKey("dbo.LivroAutor", new[] { "Autor_Id", "Livro_Id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.LivroAutor");
            AddPrimaryKey("dbo.LivroAutor", new[] { "Livro_Id", "Autor_Id" });
            RenameTable(name: "dbo.LivroAutor", newName: "LivroAutors");
            RenameTable(name: "dbo.Categoria", newName: "Categorias");
            RenameTable(name: "dbo.Livro", newName: "Livroes");
            RenameTable(name: "dbo.Autor", newName: "Autors");
        }
    }
}