import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IResponse } from '@shared/responses/response';
import { IAuthentication } from '@shared/responses/authentication.response';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private http: HttpClient) { }

  signin(email: string, password: string): Observable<IAuthentication> {
    return this.http.post<IAuthentication>(environment.apiUrl + 'authentication/signin', { email, password });
  }

}