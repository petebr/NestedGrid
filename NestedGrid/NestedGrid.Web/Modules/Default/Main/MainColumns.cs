using Serenity.ComponentModel;
using System.ComponentModel;

namespace NestedGrid.Default.Columns
{
    [ColumnsScript("Default.Main")]
    [BasedOnRow(typeof(MainRow), CheckNames = true)]
    public class MainColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Name { get; set; }
    }
}