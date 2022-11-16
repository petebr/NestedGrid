using Serenity.ComponentModel;
using Serenity.Web;

namespace NestedGrid.Default.Forms
{
    [FormScript("Default.ChildB")]
    [BasedOnRow(typeof(ChildBRow), CheckNames = true)]
    public class ChildBForm
    {
        public int ChildAId { get; set; }
        public string Name { get; set; }
    }
}