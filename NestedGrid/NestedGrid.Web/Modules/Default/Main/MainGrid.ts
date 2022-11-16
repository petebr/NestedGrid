namespace NestedGrid.Default {

    @Serenity.Decorators.registerClass()
    export class MainGrid extends Serenity.EntityGrid<MainRow, any> {
        protected getColumnsKey() { return MainColumns.columnsKey; }
        protected getDialogType() { return MainDialog; }
        protected getIdProperty() { return MainRow.idProperty; }
        protected getInsertPermission() { return MainRow.insertPermission; }
        protected getLocalTextPrefix() { return MainRow.localTextPrefix; }
        protected getService() { return MainService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}