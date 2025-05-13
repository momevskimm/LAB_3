namespace IT_LAB3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_database : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Doctors", "HospitalId");
            AddForeignKey("dbo.Doctors", "HospitalId", "dbo.Hospitals", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "HospitalId", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "HospitalId" });
        }
    }
}
