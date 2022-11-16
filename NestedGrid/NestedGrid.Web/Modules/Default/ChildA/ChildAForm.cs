using Serenity.ComponentModel;
using Serenity.Web;

namespace NestedGrid.Default.Forms
{
    [FormScript("Default.ChildA")]
    [BasedOnRow(typeof(ChildARow), CheckNames = true)]
    public class ChildAForm
    {
        public string Name { get; set; }
    }
}