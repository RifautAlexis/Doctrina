import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import {
    HttpEvent,
    HttpInterceptor,
    HttpHandler,
    HttpRequest,
    HttpErrorResponse
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Snackbar } from '@shared/components/snackbar.component';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {
    constructor(
        private router: Router,
        private _snackBar: MatSnackBar
    ) { }

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        return next.handle(request)
            .pipe(
                catchError((err: HttpErrorResponse) => {

                    if (err.status === 400) {
                        new Snackbar(this._snackBar).openSnackBarError(err.error.message);
                        throw err;
                    } else if(err.status === 401) {

                    } else if(err.status === 403) {

                    } else if(err.status === 500) {

                    }
                    
                    throw err;
                }));
        
    }
}