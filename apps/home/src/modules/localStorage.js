// @flow
export const loadItem = (name: string): JSON => {
    try {
        const serializedItem = localStorage.getItem(name);
        if (serializedItem === null) {
            return undefined;
        }
        return JSON.parse(serializedItem);
    } catch (err) {
        return undefined;
    }
}

export const saveItem = (name: string, item: any): void => {
    try {
        const serializedItem = JSON.stringify(item);
        localStorage.setItem(name, serializedItem);
    } catch (err) {
        //TODOUpdate Add Logging
    }
}