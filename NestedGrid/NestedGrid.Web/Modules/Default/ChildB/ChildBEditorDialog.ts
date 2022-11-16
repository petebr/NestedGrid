namespace NestedGrid.Default {

    @Serenity.Decorators.registerClass()
    export class ChildBEditorDialog extends Serenity.Extensions.GridEditorDialog<ChildBRow> {
        protected getFormKey() { return ChildBForm.formKey; }
        protected getLocalTextPrefix() { return ChildBRow.localTextPrefix; }
        protected getNameProperty() { return ChildBRow.nameProperty; }
        protected getService() { return ChildBService.baseUrl; }

        //protected getDeletePermission() { return ChildBRow.deletePermission; }
        //protected getInsertPermission() { return ChildBRow.insertPermission; }
        //protected getUpdatePermission() { return ChildBRow.updatePermission; }

        protected form = new ChildBForm(this.idPrefix);

    }
}