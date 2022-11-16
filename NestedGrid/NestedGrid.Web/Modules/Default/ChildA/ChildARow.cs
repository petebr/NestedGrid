using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace NestedGrid.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[ChildA]")]
    [DisplayName("Child A"), InstanceName("Child A")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ChildARow : Row<ChildARow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Main"), NotNull, ForeignKey("[dbo].[Main]", "Id"), LeftJoin("jMain"), TextualField("MainName")]
        public int? MainId
        {
            get => fields.MainId[this];
            set => fields.MainId[this] = value;
        }

        [DisplayName("Name"), Size(100), QuickSearch, NameProperty]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Main Name"), Expression("jMain.[Name]")]
        public string MainName
        {
            get => fields.MainName[this];
            set => fields.MainName[this] = value;
        }

        public ChildARow()
            : base()
        {
        }

        public ChildARow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field MainId;
            public StringField Name;

            public StringField MainName;
        }
    }
}