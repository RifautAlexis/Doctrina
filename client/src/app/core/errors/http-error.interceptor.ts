import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpEvent, HttpHandler, HttpRequest, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, finalize } from 'rxjs/operators';

@Injectable()
export class HttpErrorInterceptor implements HttpInterceptor {
  constructor(
    // private errorDialogService: ErrorDialogService,
    // private loadingDialogService: LoadingDialogService
  ) { }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(request).pipe(
      catchError((error: HttpErrorResponse) => {
        console.error("Error from error interceptor", error);

        if (error.status === 400) {
          throw error;
        } else if (error.status === 401) {

        } else if (error.status === 403) {

        } else if (error.status === 500) {

        }
        return throwError(error);
      }),
      finalize(() => {
        console.log("Finalize");
      })
    ) as Observable<HttpEvent<any>>;
  }
}