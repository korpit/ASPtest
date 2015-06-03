namespace EntityMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Post", "Course_CourseID", c => c.Int());
            AddColumn("dbo.Post", "Enrollment_EnrollmentID", c => c.Int());
            CreateIndex("dbo.Post", "Course_CourseID");
            CreateIndex("dbo.Post", "Enrollment_EnrollmentID");
            AddForeignKey("dbo.Post", "Course_CourseID", "dbo.Course", "CourseID");
            AddForeignKey("dbo.Post", "Enrollment_EnrollmentID", "dbo.Enrollment", "EnrollmentID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Post", "Enrollment_EnrollmentID", "dbo.Enrollment");
            DropForeignKey("dbo.Post", "Course_CourseID", "dbo.Course");
            DropIndex("dbo.Post", new[] { "Enrollment_EnrollmentID" });
            DropIndex("dbo.Post", new[] { "Course_CourseID" });
            DropColumn("dbo.Post", "Enrollment_EnrollmentID");
            DropColumn("dbo.Post", "Course_CourseID");
        }
    }
}
