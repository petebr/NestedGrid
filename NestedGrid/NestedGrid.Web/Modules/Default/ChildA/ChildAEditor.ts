namespace NestedGrid.Default {

    @Serenity.Decorators.registerClass()
    export class ChildAEditor extends Serenity.Extensions.GridEditorBase<ChildARow> {
        protected getColumnsKey() { return ChildAColumns.columnsKey; }
        protected getDialogType() { return ChildAEditorDialog; }
 //       protected getInsertPermission() { return ChildARow.insertPermission; }
        protected getLocalTextPrefix() { return ChildARow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}