using Serenity.ComponentModel;
using Serenity.Web;
using System.Collections.Generic;
using System.ComponentModel;

namespace NestedGrid.Default.Forms
{
    [FormScript("Default.Main")]
    [BasedOnRow(typeof(MainRow), CheckNames = true)]
    public class MainForm
    {
        public string Name { get; set; }

        [ChildAEditor]
        //, IgnoreName]
        [LabelWidth(0), DisplayName("")]
        public List<ChildARow> ChildrenA{ get; set; }
    }
}