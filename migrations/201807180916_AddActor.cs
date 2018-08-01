using FluentMigrator;

namespace migrations 
{
    [Migration(2018070916)]
    public class AddActor : Migration
    {
        public override void Up()
        {
            Create.Table("actor")
            .WithColumn("actor_id").AsInt32().PrimaryKey().Identity()
            .WithColumn("first_name").AsAnsiString(45).NotNullable()
            .WithColumn("last_name").AsAnsiString(45).NotNullable()
            .WithColumn("last_update").AsDateTime().NotNullable();
        }

        public override void Down()
        {
            // Doesn't actually delete the entire table, it "drops" it.
            Delete.Table("actor");
        }
    }
}