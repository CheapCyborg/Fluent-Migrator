using FluentMigrator;

namespace migrations
{
    [Migration(2018071048)]
    public class AddAddress : Migration
    {
        public override void Up()
        {
            Create.Table("address")
            .WithColumn("address_id").AsInt32().PrimaryKey().Identity()
            .WithColumn("address").AsAnsiString(50).NotNullable()
            .WithColumn("address2").AsAnsiString(50).Nullable()
            .WithColumn("district").AsAnsiString(20).NotNullable()
            .WithColumn("city_id").AsInt32().NotNullable()
            .WithColumn("postal_code").AsAnsiString(10).Nullable()
            .WithColumn("phone").AsAnsiString(20).NotNullable()
            .WithColumn("last_update").AsDateTime().NotNullable();

            Create.ForeignKey("fk_address_city_id")
            .FromTable("address").ForeignColumn("city_id")
            .ToTable("city").PrimaryColumn("city_id");
        }

        public override void Down()
        {
            Delete.Table("address");
        }
    }
}