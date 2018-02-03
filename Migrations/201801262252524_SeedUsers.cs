namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'151dcacf-1bc1-48fb-b62c-e74817fb9192', N'admin@vidly.com', 0, N'AD0uOqV0Q7+ZKjCAeGscsgbfD1bMQxvk7a8sNRoAPLvCAef9eDtHRqdJgFcFL2sJtw==', N'1bb5eecb-edcf-4274-98d3-e9154c58a752', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2752ff9e-9f83-4382-8e72-f4eb95deafaf', N'guest@vidly.com', 0, N'ADYPhysv7dgtK8wvfrIWv3iiIsF5KXEaQ+lEGsNXwHkcu9e5FxZ9o2dEznFuJ2G1SQ==', N'768ecf48-425f-4cdb-9b1c-2302b7be5af3', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'511f3d3c-8bcd-40b7-a88d-eb0b788517da', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'151dcacf-1bc1-48fb-b62c-e74817fb9192', N'511f3d3c-8bcd-40b7-a88d-eb0b788517da')


                ");
        }
        
        public override void Down()
        {
        }
    }
}
