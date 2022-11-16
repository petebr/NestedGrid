using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace NestedGrid.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[ChildB]")]
    [DisplayName("Child B"), InstanceName("Child B")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ChildBRow : Row<ChildBRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Child A"), NotNull, ForeignKey("[dbo].[ChildA]", "Id"), LeftJoin("jChildA"), TextualField("ChildAName")]
        public int? ChildAId
        {
            get => fields.ChildAId[this];
            set => fields.ChildAId[this] = value;
        }

        [DisplayName("Name"), Size(100), QuickSearch, NameProperty]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Child A Main Id"), Expression("jChildA.[MainId]")]
        public int? ChildAMainId
        {
            get => fields.ChildAMainId[this];
            set => fields.ChildAMainId[this] = value;
        }

        [DisplayName("Child A Name"), Expression("jChildA.[Name]")]
        public string ChildAName
        {
            get => fields.ChildAName[this];
            set => fields.ChildAName[this] = value;
        }

        public ChildBRow()
            : base()
        {
        }

        public ChildBRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field ChildAId;
            public StringField Name;

            public Int32Field ChildAMainId;
            public StringField ChildAName;
        }
    }
}