using FluentMigrator;

namespace migrations
{
    [Migration(2018071058)]
    public class AddCity : Migration
    {
        public override void Up()
        {
            Create.Table("city")
            .WithColumn("city_id").AsInt32().PrimaryKey().Identity()
            .WithColumn("country_id").AsInt32().NotNullable()
            .WithColumn("last_update").AsDateTime().NotNullable();

            Create.ForeignKey("fk_city_country_id")
            .FromTable("city").ForeignColumn("country_id")
            .ToTable("country").PrimaryColumn("country_id");
        }

        public override void Down()
        {
            throw new System.NotImplementedException();
        }
    }
}