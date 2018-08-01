using FluentMigrator;

namespace migrations
{
    [Migration(2018070938)]
    public class AddFilm : Migration
    {
        public override void Up()
        {
            Create.Table("film")
            .WithColumn("film_id").AsInt32().PrimaryKey().Identity()
            .WithColumn("title").AsAnsiString(255).NotNullable()
            .WithColumn("description").AsString()
            .WithColumn("release_year").AsAnsiString(4)
            .WithColumn("language_id").AsByte().NotNullable()
            .WithColumn("original_language_id").AsByte()
            .WithColumn("rental_duration").AsByte()
            .WithColumn("length").AsInt16()
            .WithColumn("replacment_cost").AsDecimal(5, 2).NotNullable()
            .WithColumn("rating").AsAnsiString(255)
            .WithColumn("specal_features").AsAnsiString(255)
            .WithColumn("last_update").AsDateTime().NotNullable();
        }

        public override void Down()
        {
            // Doesn't actually delete the entire table, it "drops" it.
            Delete.Table("film");
        }
    }
}