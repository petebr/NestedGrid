namespace NestedGrid.Default {
    export interface ChildAForm {
        MainId: Serenity.IntegerEditor;
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
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;

                Q.initFormType(ChildAForm, [
                    'MainId', w0,
                    'Name', w1
                ]);
            }
        }
    }
}
