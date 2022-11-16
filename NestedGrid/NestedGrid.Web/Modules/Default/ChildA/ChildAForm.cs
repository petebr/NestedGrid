using Serenity.ComponentModel;
using Serenity.Web;
using System.Collections.Generic;
using System.ComponentModel;

namespace NestedGrid.Default.Forms
{
    [FormScript("Default.ChildA")]
    [BasedOnRow(typeof(ChildARow), CheckNames = true)]
    public class ChildAForm
    {
        public string Name { get; set; }

        [ChildBEditor]
        
        [LabelWidth(0), DisplayName("")]
        public List<ChildBRow> ChildrenB { get; set; }
    }
}