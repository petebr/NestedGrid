namespace NestedGrid.Default {

    @Serenity.Decorators.registerClass()
    export class ChildADialog extends Serenity.EntityDialog<ChildARow, any> {
        protected getFormKey() { return ChildAForm.formKey; }
        protected getIdProperty() { return ChildARow.idProperty; }
        protected getLocalTextPrefix() { return ChildARow.localTextPrefix; }
        protected getNameProperty() { return ChildARow.nameProperty; }
        protected getService() { return ChildAService.baseUrl; }
        protected getDeletePermission() { return ChildARow.deletePermission; }
        protected getInsertPermission() { return ChildARow.insertPermission; }
        protected getUpdatePermission() { return ChildARow.updatePermission; }

        protected form = new ChildAForm(this.idPrefix);

    }
}