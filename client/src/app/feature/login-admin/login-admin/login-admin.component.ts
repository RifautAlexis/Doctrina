import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthenticationService } from '@core/authentication/authentication.service';
import { Role, Status } from '@shared/enum';
import { Authentication } from '@shared/models/authentication.model';
import { AuthenticationResponse } from '@shared/responses/authentication.response';

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
    this.adminForm = this.formBuilder.group({
      email: ["", Validators.required],
      password: ["", Validators.required]
    });
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.adminForm.controls[controlName].hasError(errorName);
  }

  public submitForm() {
    const { email, password } = this.adminForm.value as ILoginForm;

    this.authenticationService.login(email, password).subscribe(
      (response: Authentication) => {
        this.router.navigate(['dashboard']);
      }
    );
  }
  

}

interface ILoginForm {
  email: string;
  password: string;
}
