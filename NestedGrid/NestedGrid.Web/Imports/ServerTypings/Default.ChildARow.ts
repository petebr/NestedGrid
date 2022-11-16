namespace NestedGrid.Default {
    export interface ChildARow {
        Id?: number;
        MainId?: number;
        Name?: string;
        MainName?: string;
        ChildrenB?: ChildBRow[];
    }

    export namespace ChildARow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Default.ChildA';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            MainId = "MainId",
            Name = "Name",
            MainName = "MainName",
            ChildrenB = "ChildrenB"
        }
    }
}
