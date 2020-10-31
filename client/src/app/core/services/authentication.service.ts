import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IAuthenticationResponse } from '@shared/responses/authentication.response';
import { Role, Status } from '@shared/enum';
import * as jwtdecode from 'jwt-decode';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private http: HttpClient) { }

  signin(email: string, password: string): Observable<IAuthenticationResponse> {
    return this.http.post<IAuthenticationResponse>(environment.apiUrl + 'authentication/signin', { email, password })
      .pipe(
        map((response: IAuthenticationResponse) => {
          return {status: Status.SUCCESSFUL, data: response.data}
        })
      );
  }

  getCurrentUserRole(): Role {
    let token: string = localStorage.getItem('currentToken');
    if(token == null) return null;

    let decodedToken: IToken = jwtdecode(token);

    if (decodedToken.role === "Admin") {
      return Role.Admin;
    } else if (decodedToken.role === "Member") {
      return Role.Member;
    } else {
      return null;
    }
  }
}

interface IToken {
  unique_name: string
  role: string;
}