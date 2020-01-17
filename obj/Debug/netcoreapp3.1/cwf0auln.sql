IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Cars] (
    [CarId] int NOT NULL IDENTITY,
    [CarName] nvarchar(max) NULL,
    [CarModel] nvarchar(max) NULL,
    [CarPrice] int NOT NULL,
    [Year] int NOT NULL,
    [PhoneNumber] nvarchar(max) NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY ([CarId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200117120626_initial', N'3.1.1');

GO

