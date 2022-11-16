using Serenity.ComponentModel;
using System.ComponentModel;

namespace NestedGrid.Default.Columns
{
    [ColumnsScript("Default.ChildA")]
    [BasedOnRow(typeof(ChildARow), CheckNames = true)]
    public class ChildAColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        public string MainName { get; set; }
        [EditLink]
        public string Name { get; set; }
    }
}