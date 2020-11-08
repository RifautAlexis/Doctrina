import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IAuthenticationResponse } from '@shared/responses/authentication.response';
import { Status } from '@shared/enum';
import { IAuthentication } from '@shared/models/authentication.model';
import { environment } from '../../../environments/environment';
import { Router } from '@angular/router';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
    private currentUser$: BehaviorSubject<IAuthentication>;

    constructor(
        private http: HttpClient,
        private router: Router
    ) {
        this.currentUser$ = new BehaviorSubject<IAuthentication>(JSON.parse(localStorage.getItem('currentUser')));
    }

    public get currentUserValue(): IAuthentication {
        return this.currentUser$.value;
    }

    public get isConnected(): Observable<boolean> {
        return this.currentUser$.pipe(map((auth: IAuthentication) => auth != null));
    }

    login(email: string, password: string): Observable<IAuthenticationResponse> {
        return this.http.post<IAuthenticationResponse>(`${environment.apiUrl}authentication/signin`, { email, password })
            .pipe(
                map((response: IAuthenticationResponse) => {
                    localStorage.setItem('currentUser', JSON.stringify(response.data));
                    this.currentUser$.next(response.data);
                    return { status: Status.SUCCESSFUL, data: response.data };
                }));
    }

    logout() {
        localStorage.removeItem('currentUser');
        this.currentUser$.next(null);
        if (this.router.url.includes("dashboard")) {
            this.router.navigate(['/']);
        }
    }
}