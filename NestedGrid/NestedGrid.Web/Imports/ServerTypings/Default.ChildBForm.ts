namespace NestedGrid.Default {
    export interface ChildBForm {
        ChildAId: Serenity.IntegerEditor;
        Name: Serenity.StringEditor;
    }

    export class ChildBForm extends Serenity.PrefixedContext {
        static formKey = 'Default.ChildB';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ChildBForm.init)  {
                ChildBForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;

                Q.initFormType(ChildBForm, [
                    'ChildAId', w0,
                    'Name', w1
                ]);
            }
        }
    }
}
