IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Articulo] (
    [Articulo_Id] nvarchar(15) NOT NULL,
    [CreadoEn] datetime2 NOT NULL DEFAULT (GETDATE()),
    [ModificadoEn] datetime2 NOT NULL DEFAULT (GETDATE()),
    [ModificadoPor] nvarchar(20) NOT NULL,
    [Articulo_Nombre] nvarchar(100) NOT NULL,
    [Articulo_Descripcion] nvarchar(2000) NOT NULL,
    [Articulo_Precio] money(9,4) NOT NULL,
    CONSTRAINT [PK_Articulo] PRIMARY KEY ([Articulo_Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201031001453_Initial_Migration', N'3.1.9');

GO

