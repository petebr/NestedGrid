namespace NestedGrid.Default {

    @Serenity.Decorators.registerClass()
    export class ChildAGrid extends Serenity.EntityGrid<ChildARow, any> {
        protected getColumnsKey() { return ChildAColumns.columnsKey; }
        protected getDialogType() { return ChildADialog; }
        protected getIdProperty() { return ChildARow.idProperty; }
        protected getInsertPermission() { return ChildARow.insertPermission; }
        protected getLocalTextPrefix() { return ChildARow.localTextPrefix; }
        protected getService() { return ChildAService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}