namespace NestedGrid.Default {
    export interface ChildBRow {
        Id?: number;
        ChildAId?: number;
        Name?: string;
        ChildAMainId?: number;
        ChildAName?: string;
    }

    export namespace ChildBRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Default.ChildB';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            ChildAId = "ChildAId",
            Name = "Name",
            ChildAMainId = "ChildAMainId",
            ChildAName = "ChildAName"
        }
    }
}
