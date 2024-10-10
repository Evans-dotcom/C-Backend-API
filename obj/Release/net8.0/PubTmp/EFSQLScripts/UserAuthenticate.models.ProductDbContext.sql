IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240920122429_InitialDB'
)
BEGIN
    CREATE TABLE [Products] (
        [Id] int NOT NULL IDENTITY,
        [ProductName] nvarchar(max) NULL,
        [ManufacturerName] nvarchar(max) NULL,
        [ManufacturerBrand] nvarchar(max) NULL,
        [Price] decimal(18,2) NOT NULL,
        [ImagePath] nvarchar(max) NULL,
        [Category] nvarchar(max) NULL,
        [Features] nvarchar(max) NULL,
        [ProductDescription] nvarchar(max) NULL,
        [MetaTitle] nvarchar(max) NULL,
        [MetaKeywords] nvarchar(max) NULL,
        [MetaDescription] nvarchar(max) NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240920122429_InitialDB'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240920122429_InitialDB', N'8.0.0');
END;
GO

COMMIT;
GO

