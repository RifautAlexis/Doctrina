import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from '@core/authentication/authentication.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'header-layout',
  templateUrl: './header-layout.component.html',
  styleUrls: ['./header-layout.component.scss']
})
export class HeaderLayoutComponent implements OnInit {

  isConnected$: Observable<boolean>;

  constructor(
    private authService: AuthenticationService
  ) { }

  ngOnInit(): void {
    this.isConnected$ = this.authService.isConnected;
  }

  logout() {
    this.authService.logout();
  }

}
