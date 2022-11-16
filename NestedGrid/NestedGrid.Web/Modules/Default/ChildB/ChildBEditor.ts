namespace NestedGrid.Default {

    @Serenity.Decorators.registerClass()
    export class ChildBEditor extends Serenity.Extensions.GridEditorBase<ChildBRow> {
        protected getColumnsKey() { return ChildBColumns.columnsKey; }
        protected getDialogType() { return ChildBEditorDialog; }
 //       protected getInsertPermission() { return ChildBRow.insertPermission; }
        protected getLocalTextPrefix() { return ChildBRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}