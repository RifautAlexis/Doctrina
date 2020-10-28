import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IAuthenticationResponse } from '@shared/responses/authentication.response';
import { Role } from '@shared/enum';
import * as jwtdecode from 'jwt-decode';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private http: HttpClient) { }

  signin(email: string, password: string): Observable<IAuthenticationResponse> {
    return this.http.post<IAuthenticationResponse>(environment.apiUrl + 'authentication/signin', { email, password });
  }

  getCurrentUserRole(): Role {
    let token: string = localStorage.getItem('currentToken');
    if(token == null) return null;

    let decodedToken: Token = jwtdecode(token);

    if (decodedToken.role === "Admin") {
      return Role.Admin;
    } else if (decodedToken.role === "Member") {
      return Role.Member;
    } else {
      return null;
    }
  }
}

interface Token {
  unique_name: string
  role: string;
}