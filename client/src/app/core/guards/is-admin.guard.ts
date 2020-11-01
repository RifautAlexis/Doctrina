import { Injectable } from '@angular/core';
import { Router, CanActivate } from '@angular/router';
import { AuthenticationService } from '../authentication/authentication.service';
import { Role } from '@shared/enum';
import { IAuthentication } from '@shared/models/authentication.model';

@Injectable({
  providedIn: 'root',
})
export class IsAdminGuard implements CanActivate {
  constructor(public authenticationService: AuthenticationService, public router: Router) {}

  canActivate(): boolean {
    let currentUser: IAuthentication = this.authenticationService.currentUserValue;
    if (!currentUser || currentUser.user?.role !== Role.Admin) {
      this.router.navigate(['admin']);
      return false;
    }
    return true;
  }
}
