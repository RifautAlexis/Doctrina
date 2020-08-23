import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {


        let currentToken: string = localStorage.getItem('currentToken');

        if (currentToken) {

            request = request.clone({
                setHeaders: {
                    Authorization: `Bearer ${currentToken}`
                }
            });

        }

        return next.handle(request);
    }
}