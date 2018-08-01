using FluentMigrator;

namespace migrations
{
    [Migration(2018071106)]
    public class AddCountry : Migration
    {
        public override void Up()
        {
            Create.Table("country")
            .WithColumn("country_id").AsInt32().PrimaryKey().Identity()
            .WithColumn("country").AsInt32().NotNullable()
            .WithColumn("last_update").AsDateTime().NotNullable();
        }

        public override void Down()
        {
            throw new System.NotImplementedException();
        }
    }
}