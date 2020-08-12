namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'33c54877-f60b-4957-8ca7-d2b722766bec', N'admin@vidly.com', 0, N'AG0T9pOJDjOE+9MbzbSgejiIb5StWScZGm3LgA2o5IwjhdeI0BBI3mayp+aesnZMpQ==', N'67784100-a082-4e40-bbe0-39a27598b620', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'83c001d3-039e-4f2a-897f-d960924bb175', N'guest@vidly.com', 0, N'AK3nvIrwwAlhazjv0gtqyrcOePAt/LsiDQR4VC96O6p3r0oUbuSXToDpmdvfNR9FfA==', N'526485dd-be3d-4593-acea-7ecfeb7cf0a6', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ffdea729-e877-4b35-9f62-2a20ff16c09b', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'33c54877-f60b-4957-8ca7-d2b722766bec', N'ffdea729-e877-4b35-9f62-2a20ff16c09b')

");
        }

        public override void Down()
        {
        }
    }
}
