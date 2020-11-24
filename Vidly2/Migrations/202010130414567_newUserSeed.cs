namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newUserSeed : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'0cbaad13-64bb-407a-9e00-fb032a4b50e0', N'admin@vidly.com', 0, N'AGQekoY165zePrDbiY1UzcaApqOk/myjqER2eAmrXHx2i/B1hjIed6sBxuST9wzT/w==', N'5ada5052-9638-483a-ad7d-cd694fd4a6a9', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com', N'123456', N'123456')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a33455a4-0c22-46d4-9ca8-209e182cb615', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0cbaad13-64bb-407a-9e00-fb032a4b50e0', N'a33455a4-0c22-46d4-9ca8-209e182cb615')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
