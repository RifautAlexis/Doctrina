import 'package:client/components/snackbar.dart';
import 'package:client/datas/http_error.dart';
import 'package:client/datas/responses/authentication_response.dart';
import 'package:client/mobx/authentication_store.dart';
import 'package:client/screens/login_admin/mobx/form_login_admin_error_state.dart';
import 'package:client/services/authentication_service.dart';
import 'package:flutter/material.dart';
import 'package:mobx/mobx.dart';
import 'package:validators/validators.dart';
import 'dart:html' as html;

part 'form_login_admin_store.g.dart';

class FormLoginAdminStore = _FormLoginAdminStore with _$FormLoginAdminStore;

abstract class _FormLoginAdminStore with Store {
  _FormLoginAdminStore({@required this.authStore, @required this.authService});

  final AuthenticationStore authStore;
  final AuthenticationService authService;

  @observable
  String email = '';

  @observable
  String password = '';

  @computed
  bool get canSubmit => !error.hasErrors;

  final FormLoginAdminErrorState error = FormLoginAdminErrorState();

  @observable
  ObservableFuture<AuthenticationResponse> loginFuture =
      ObservableFuture.value(null);

  @computed
  bool get loginPending => loginFuture.status == FutureStatus.pending;

  @computed
  bool get loginError => loginFuture.status == FutureStatus.rejected;

  @computed
  bool get loginSuccessful => loginFuture.status == FutureStatus.fulfilled;

  @action
  void validateEmail() {
    error.email = isNull(email) || email.isEmpty ? 'Cannot be empty' : null;
  }

  @action
  void validatePassword() {
    error.password =
        isNull(password) || password.isEmpty ? 'Cannot be empty' : null;
  }

  @action
  Future<bool> validateAllFields() async {
    validateEmail();
    validatePassword();
    return !error.hasErrors;
  }

  @action
  Future<void> loginAdmin() async {
    try {
      loginFuture = ObservableFuture(authService.loginAdmin(email, password));
      final authenticationResponse = await loginFuture;
      authStore.user = authenticationResponse.user;
      authStore.token = authenticationResponse.token;
      authStore.setJWTInLocalStorage(authenticationResponse.token);
    } on HttpError catch (failure) {
      Snackbar.createError(message: failure.errorMesage);
    } catch (failure) {
      Snackbar.createError();
    }
  }
}
