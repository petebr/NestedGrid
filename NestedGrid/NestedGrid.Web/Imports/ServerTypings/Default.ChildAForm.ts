namespace NestedGrid.Default {
    export interface ChildAForm {
        Name: Serenity.StringEditor;
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

                Q.initFormType(ChildAForm, [
                    'Name', w0
                ]);
            }
        }
    }
}
