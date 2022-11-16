using Serenity.ComponentModel;
using System.ComponentModel;

namespace NestedGrid.Default.Columns
{
    [ColumnsScript("Default.ChildB")]
    [BasedOnRow(typeof(ChildBRow), CheckNames = true)]
    public class ChildBColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public string ChildAName { get; set; }
        [EditLink]
        public string Name { get; set; }
    }
}