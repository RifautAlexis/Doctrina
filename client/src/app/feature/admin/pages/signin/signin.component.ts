import { Component, OnInit } from '@angular/core';
import { EmailValidator, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { AuthenticationService } from '@core/services/authentication.service';
import { IAuthentication } from '@shared/responses/authentication.response';
import { IResponse } from '@shared/responses/response';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.scss']
})
export class SigninComponent implements OnInit {

  public adminForm: FormGroup

  constructor(
    private authenticationService: AuthenticationService,
    public formBuilder: FormBuilder
  ) { }

  ngOnInit(): void {
    this.buildAdminForm();
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.adminForm.controls[controlName].hasError(errorName);
  }

  public submitForm() {
    const {email, password} = this.adminForm.value as ITest;

    this.authenticationService.signin(email, password).subscribe(
      (response: IAuthentication) => {
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
