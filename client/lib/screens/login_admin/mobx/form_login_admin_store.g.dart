// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'form_login_admin_store.dart';

// **************************************************************************
// StoreGenerator
// **************************************************************************

// ignore_for_file: non_constant_identifier_names, unnecessary_brace_in_string_interps, unnecessary_lambdas, prefer_expression_function_bodies, lines_longer_than_80_chars, avoid_as, avoid_annotating_with_dynamic

mixin _$FormLoginAdminStore on _FormLoginAdminStore, Store {
  Computed<bool> _$canSubmitComputed;

  @override
  bool get canSubmit =>
      (_$canSubmitComputed ??= Computed<bool>(() => super.canSubmit,
              name: '_FormLoginAdminStore.canSubmit'))
          .value;
  Computed<bool> _$loginPendingComputed;

  @override
  bool get loginPending =>
      (_$loginPendingComputed ??= Computed<bool>(() => super.loginPending,
              name: '_FormLoginAdminStore.loginPending'))
          .value;
  Computed<bool> _$loginErrorComputed;

  @override
  bool get loginError =>
      (_$loginErrorComputed ??= Computed<bool>(() => super.loginError,
              name: '_FormLoginAdminStore.loginError'))
          .value;
  Computed<bool> _$loginSuccessfulComputed;

  @override
  bool get loginSuccessful =>
      (_$loginSuccessfulComputed ??= Computed<bool>(() => super.loginSuccessful,
              name: '_FormLoginAdminStore.loginSuccessful'))
          .value;

  final _$emailAtom = Atom(name: '_FormLoginAdminStore.email');

  @override
  String get email {
    _$emailAtom.reportRead();
    return super.email;
  }

  @override
  set email(String value) {
    _$emailAtom.reportWrite(value, super.email, () {
      super.email = value;
    });
  }

  final _$passwordAtom = Atom(name: '_FormLoginAdminStore.password');

  @override
  String get password {
    _$passwordAtom.reportRead();
    return super.password;
  }

  @override
  set password(String value) {
    _$passwordAtom.reportWrite(value, super.password, () {
      super.password = value;
    });
  }

  final _$loginFutureAtom = Atom(name: '_FormLoginAdminStore.loginFuture');

  @override
  ObservableFuture<AuthenticationResponse> get loginFuture {
    _$loginFutureAtom.reportRead();
    return super.loginFuture;
  }

  @override
  set loginFuture(ObservableFuture<AuthenticationResponse> value) {
    _$loginFutureAtom.reportWrite(value, super.loginFuture, () {
      super.loginFuture = value;
    });
  }

  final _$validateAllFieldsAsyncAction =
      AsyncAction('_FormLoginAdminStore.validateAllFields');

  @override
  Future<bool> validateAllFields() {
    return _$validateAllFieldsAsyncAction.run(() => super.validateAllFields());
  }

  final _$loginAdminAsyncAction =
      AsyncAction('_FormLoginAdminStore.loginAdmin');

  @override
  Future<void> loginAdmin() {
    return _$loginAdminAsyncAction.run(() => super.loginAdmin());
  }

  final _$_FormLoginAdminStoreActionController =
      ActionController(name: '_FormLoginAdminStore');

  @override
  void validateEmail() {
    final _$actionInfo = _$_FormLoginAdminStoreActionController.startAction(
        name: '_FormLoginAdminStore.validateEmail');
    try {
      return super.validateEmail();
    } finally {
      _$_FormLoginAdminStoreActionController.endAction(_$actionInfo);
    }
  }

  @override
  void validatePassword() {
    final _$actionInfo = _$_FormLoginAdminStoreActionController.startAction(
        name: '_FormLoginAdminStore.validatePassword');
    try {
      return super.validatePassword();
    } finally {
      _$_FormLoginAdminStoreActionController.endAction(_$actionInfo);
    }
  }

  @override
  String toString() {
    return '''
email: ${email},
password: ${password},
loginFuture: ${loginFuture},
canSubmit: ${canSubmit},
loginPending: ${loginPending},
loginError: ${loginError},
loginSuccessful: ${loginSuccessful}
    ''';
  }
}
