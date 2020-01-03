DELETE FROM [Products]
WHERE [Id] = 12;
SELECT @@ROWCOUNT;


GO

DELETE FROM [Products]
WHERE [Id] = 13;
SELECT @@ROWCOUNT;


GO

UPDATE [Products] SET [Name] = N'Apple Macbook Pro 2020'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;


GO

DELETE FROM [__EFMigrationsHistory]
WHERE [MigrationId] = N'20200103095713_update-product';

GO

