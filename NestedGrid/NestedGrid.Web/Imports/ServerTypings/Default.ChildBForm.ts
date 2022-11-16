namespace NestedGrid.Default {
    export interface ChildBForm {
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
                var w0 = s.StringEditor;

                Q.initFormType(ChildBForm, [
                    'Name', w0
                ]);
            }
        }
    }
}
