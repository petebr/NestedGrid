namespace NestedGrid.Default {

    @Serenity.Decorators.registerClass()
    export class ChildAEditorDialog extends Serenity.Extensions.GridEditorDialog<ChildARow> {
        protected getFormKey() { return ChildAForm.formKey; }
        protected getLocalTextPrefix() { return ChildARow.localTextPrefix; }
        protected getNameProperty() { return ChildARow.nameProperty; }
        protected getService() { return ChildAService.baseUrl; }

        //protected getDeletePermission() { return ChildARow.deletePermission; }
        //protected getInsertPermission() { return ChildARow.insertPermission; }
        //protected getUpdatePermission() { return ChildARow.updatePermission; }

        protected form = new ChildAForm(this.idPrefix);

    }
}