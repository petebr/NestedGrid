namespace NestedGrid.Default {

    @Serenity.Decorators.registerClass()
    export class MainDialog extends Serenity.EntityDialog<MainRow, any> {
        protected getFormKey() { return MainForm.formKey; }
        protected getIdProperty() { return MainRow.idProperty; }
        protected getLocalTextPrefix() { return MainRow.localTextPrefix; }
        protected getNameProperty() { return MainRow.nameProperty; }
        protected getService() { return MainService.baseUrl; }
        protected getDeletePermission() { return MainRow.deletePermission; }
        protected getInsertPermission() { return MainRow.insertPermission; }
        protected getUpdatePermission() { return MainRow.updatePermission; }

        protected form = new MainForm(this.idPrefix);

    }
}