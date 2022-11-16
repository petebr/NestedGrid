namespace NestedGrid.Default {
    export interface MainForm {
        Name: Serenity.StringEditor;
        ChildrenA: ChildAEditor;
    }

    export class MainForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Main';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MainForm.init)  {
                MainForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = ChildAEditor;

                Q.initFormType(MainForm, [
                    'Name', w0,
                    'ChildrenA', w1
                ]);
            }
        }
    }
}
