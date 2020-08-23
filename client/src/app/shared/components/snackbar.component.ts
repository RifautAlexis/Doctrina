import {MatSnackBar} from '@angular/material/snack-bar';

export class Snackbar {
    constructor(private _snackBar: MatSnackBar) { }

    openSnackBarError(message: string, action: string = "") {
        this._snackBar.open(message, action, {
            duration: 10000,
        });
    }

    openSnackBarSuccess(message: string, action: string = "") {
        this._snackBar.open(message, action, {
            duration: 10000,
        });
    }
}
