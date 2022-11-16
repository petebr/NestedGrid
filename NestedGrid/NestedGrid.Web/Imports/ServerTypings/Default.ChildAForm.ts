namespace NestedGrid.Default {
    export interface ChildAForm {
        Name: Serenity.StringEditor;
        ChildrenB: ChildBEditor;
    }

    export class ChildAForm extends Serenity.PrefixedContext {
        static formKey = 'Default.ChildA';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ChildAForm.init)  {
                ChildAForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = ChildBEditor;

                Q.initFormType(ChildAForm, [
                    'Name', w0,
                    'ChildrenB', w1
                ]);
            }
        }
    }
}
