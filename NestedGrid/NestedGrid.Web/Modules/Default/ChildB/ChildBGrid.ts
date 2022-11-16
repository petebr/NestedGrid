namespace NestedGrid.Default {

    @Serenity.Decorators.registerClass()
    export class ChildBGrid extends Serenity.EntityGrid<ChildBRow, any> {
        protected getColumnsKey() { return ChildBColumns.columnsKey; }
        protected getDialogType() { return ChildBDialog; }
        protected getIdProperty() { return ChildBRow.idProperty; }
        protected getInsertPermission() { return ChildBRow.insertPermission; }
        protected getLocalTextPrefix() { return ChildBRow.localTextPrefix; }
        protected getService() { return ChildBService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}