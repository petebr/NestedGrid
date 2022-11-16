using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.Collections.Generic;
using System.ComponentModel;

namespace NestedGrid.Default
{
    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Main]")]
    [DisplayName("Main"), InstanceName("Main")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MainRow : Row<MainRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Name"), Size(100), QuickSearch, NameProperty]
        public string Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }


        [DisplayName("ChildrenA")]
        [MasterDetailRelation(foreignKey: nameof(ChildARow.MainId) )]
            //,            IncludeColumnNames = new[] { nameof(BeatRow.Scenes) })]
        public List<ChildARow> ChildrenA
        {
            get => Fields.ChildrenA[this];
            set => Fields.ChildrenA[this] = value;

        }

        public MainRow()
            : base()
        {
        }

        public MainRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
            public ListField<ChildARow> ChildrenA;
        }
    }
}