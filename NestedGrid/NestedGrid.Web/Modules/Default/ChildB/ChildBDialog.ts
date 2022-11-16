namespace NestedGrid.Default {

    @Serenity.Decorators.registerClass()
    export class ChildBDialog extends Serenity.EntityDialog<ChildBRow, any> {
        protected getFormKey() { return ChildBForm.formKey; }
        protected getIdProperty() { return ChildBRow.idProperty; }
        protected getLocalTextPrefix() { return ChildBRow.localTextPrefix; }
        protected getNameProperty() { return ChildBRow.nameProperty; }
        protected getService() { return ChildBService.baseUrl; }
        protected getDeletePermission() { return ChildBRow.deletePermission; }
        protected getInsertPermission() { return ChildBRow.insertPermission; }
        protected getUpdatePermission() { return ChildBRow.updatePermission; }

        protected form = new ChildBForm(this.idPrefix);

    }
}