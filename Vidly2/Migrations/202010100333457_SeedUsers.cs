namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9a24de96-db7a-48d8-9732-b9337a67030c', N'guest@vidly.com', 0, N'AN5UNDdUAcC9nMiAE3Ms7Ulsdwb0ihy8kFKDHqfcrIW+U92a9D951ZavNhivKz8qww==', N'46e94423-1a0c-4603-856d-cf18b3d677dc', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a58384b1-b045-4720-a5bb-dc3a93a3a0a0', N'Admin@vidly.com', 0, N'AO+vxJyDbmzkBhkYgMJ60THafHhmN4mfnPP5S0aw/27unSA7u8EOzyuRMyxShWVHAQ==', N'16018ecd-f649-4074-abb4-142b7d493b7f', NULL, 0, 0, NULL, 1, 0, N'realAdmin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b9b3e00e-88e3-4535-8b73-072821e5de58', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a58384b1-b045-4720-a5bb-dc3a93a3a0a0', N'b9b3e00e-88e3-4535-8b73-072821e5de58')
");
        }
        
        public override void Down()
        {
        }
    }
}
