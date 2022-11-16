using FluentMigrator;
using Serenity.Extensions;

namespace NestedGrid.Migrations.DefaultDB
{
    [Migration(20221116130000)]
    public class DefaultDB_20221116: AutoReversingMigration
    {
        public override void Up()
        {

            this.CreateTableWithId32("Main", "Id", s => s
                .WithColumn("Name").AsString(100).Nullable()
                );

            this.CreateTableWithId32("ChildA", "Id", s => s
               .WithColumn("MainId").AsInt32().NotNullable()
                   .ForeignKey("FK_A_Main", "Main", "Id")
               .WithColumn("Name").AsString(100).Nullable()
            );

            this.CreateTableWithId32("ChildB", "Id", s => s
               .WithColumn("ChildAId").AsInt32().NotNullable()
                   .ForeignKey("FK_B_A", "ChildA", "Id")
               .WithColumn("Name").AsString(100).Nullable()
            );
        }
    }
}