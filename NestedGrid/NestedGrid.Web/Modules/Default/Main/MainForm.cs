using Serenity.ComponentModel;
using Serenity.Web;

namespace NestedGrid.Default.Forms
{
    [FormScript("Default.Main")]
    [BasedOnRow(typeof(MainRow), CheckNames = true)]
    public class MainForm
    {
        public string Name { get; set; }
    }
}