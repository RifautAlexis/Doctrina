import { Injectable } from '@angular/core';
import { Router, CanActivate } from '@angular/router';
import { AuthenticationService } from '../services/authentication.service';
import { Role } from '@shared/enum';

@Injectable({
  providedIn: 'root',
})
export class IsAdminGuard implements CanActivate {
  constructor(public authenticationService: AuthenticationService, public router: Router) {}

  canActivate(): boolean {
    const role: Role = this.authenticationService.getCurrentUserRole();
    if (role === null || role !== Role.Admin) {
      this.router.navigate(['dashboard/signin']);
      return false;
    }
    return true;
  }
}
