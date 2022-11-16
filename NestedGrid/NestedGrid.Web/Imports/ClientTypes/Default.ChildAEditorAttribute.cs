using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace NestedGrid.Default
{
    public partial class ChildAEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "NestedGrid.Default.ChildAEditor";

        public ChildAEditorAttribute()
            : base(Key)
        {
        }
    }
}
