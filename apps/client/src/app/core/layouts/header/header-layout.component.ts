import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '@core/authentication/authentication.service';
import { StyleManagerService } from '@core/services/style-manager.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'header-layout',
  templateUrl: './header-layout.component.html',
  styleUrls: ['./header-layout.component.scss']
})
export class HeaderLayoutComponent implements OnInit {

  isConnected$: Observable<boolean>;
  isAdmin$: Observable<boolean>;
  isDarkModeOn$: Observable<boolean>;

  constructor(
    private authService: AuthenticationService,
    private styleManagerService: StyleManagerService
  ) { }

  ngOnInit(): void {
    this.isAdmin$ = this.authService.isAdmin$;
    this.isConnected$ = this.authService.isConnected$;
    this.isDarkModeOn$ = this.styleManagerService.getIsDarkModeOn$();
    // this.isDarkModeOn$.subscribe((lol) => console.log("HEADER NGONINIT => " + lol));
  }

  logout() {
    this.authService.logout();
  }

  changeTheme(isDarkModeOn: boolean) {
    // console.log("CHANGETHEME => " + isDarkModeOn);
    // this.isDarkModeOn$ = this.styleManagerService.setStyle(isDarkModeOn);
    this.isDarkModeOn$ = this.styleManagerService.toggleTheme(isDarkModeOn);
  }

  // changeTheme(isDarkModeOn: boolean) {
  //     this.styleManagerService.removeStyle('theme', isDarkModeOn);
  //   if (isDarkModeOn) {
  //     this.styleManagerService.setStyle('theme', `/assets/dark-theme.scss`, isDarkModeOn);
  //   } else {
  //     this.styleManagerService.setStyle('theme', `/assets/light-theme.scss`, isDarkModeOn);
  //   }
  // }
}
