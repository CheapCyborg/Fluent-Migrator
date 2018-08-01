using FluentMigrator;

namespace migrations
{
    [Migration(2018071033)]
    public class AddFilmCatergory : Migration
    {
        public override void Up()
        {
            Create.Table("film_category")
            .WithColumn("film_id").AsInt32().NotNullable()
            .WithColumn("category_id").AsInt32().NotNullable()
            .WithColumn("last_update").AsDateTime().NotNullable();

            Create.ForeignKey("fk_film_category_film_id")
            .FromTable("film_category").ForeignColumn("film_id")
            .ToTable("film").PrimaryColumn("film_id");

            Create.ForeignKey("fk_film_category_category_id")
            .FromTable("film_category").ForeignColumn("category_id")
            .ToTable("category").PrimaryColumn("category_id");
        }

        public override void Down()
        {
            throw new System.NotImplementedException();
        }
    }
}