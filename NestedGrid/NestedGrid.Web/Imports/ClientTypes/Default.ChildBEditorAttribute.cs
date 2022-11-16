using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace NestedGrid.Default
{
    public partial class ChildBEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "NestedGrid.Default.ChildBEditor";

        public ChildBEditorAttribute()
            : base(Key)
        {
        }
    }
}
