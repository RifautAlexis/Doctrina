import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { AuthenticationResponse } from '@shared/responses/authentication.response';
import { Role } from '@shared/enum';
import { Authentication } from '@shared/models/authentication.model';
import { environment } from '../../../environments/environment';
import { Router } from '@angular/router';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
    private currentUser$: BehaviorSubject<Authentication>;

    constructor(
        private http: HttpClient,
        private router: Router
    ) {
        this.currentUser$ = new BehaviorSubject<Authentication>(JSON.parse(localStorage.getItem('currentUser')));
    }

    public get currentUserValue(): Authentication {
        return this.currentUser$.value;
    }

    public get currentUserValue$(): BehaviorSubject<Authentication> {
        return this.currentUser$;
    }

    public get isConnected$(): Observable<boolean> {
        return this.currentUser$.pipe(map((auth: Authentication) => auth !== null));
    }

    public get isAdmin$(): Observable<boolean> {
        return this.currentUser$.pipe(map((auth: Authentication) => auth?.user?.role === Role.Admin));
    }

    login(email: string, password: string): Observable<Authentication> {
        return this.http.post<AuthenticationResponse>(`${environment.apiUrl}authentication/signin`, { email, password })
            .pipe(
                map((response: AuthenticationResponse) => {
                    localStorage.setItem('currentUser', JSON.stringify(response.data));
                    this.currentUser$.next(response.data);
                    return response.data ;
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