import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthenticationService } from '@core/services/authentication.service';
import { Role } from '@shared/enum';
import { IAuthentication } from '@shared/models/authentication.model';

@Component({
  selector: 'app-login-admin',
  templateUrl: './login-admin.component.html',
  styleUrls: ['./login-admin.component.scss']
})
export class LoginAdminComponent implements OnInit {

  public adminForm: FormGroup

  constructor(
    private authenticationService: AuthenticationService,
    public formBuilder: FormBuilder,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.buildAdminForm();
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.adminForm.controls[controlName].hasError(errorName);
  }

  public submitForm() {
    const { email, password } = this.adminForm.value as ITest;

    this.authenticationService.signin(email, password).subscribe(
      (response: IAuthentication) => {

        localStorage.setItem('currentToken', response.token);

        const role: Role = this.authenticationService.getCurrentUserRole();
        this.router.navigate(['dashboard']);
        console.log("RESPONSE", response);
      },
      (error: any) => {
        console.log("LOLOLOLOL", error);
      },
      () => {
        console.log("XXXXXXXXXXXXXXXX");
      }
    );
  }

  private buildAdminForm(): void {
    this.adminForm = this.formBuilder.group({
      email: ["", Validators.required],
      password: ["", Validators.required]
    });
  }

}

export interface ITest {
  email: string;
  password: string;
}
