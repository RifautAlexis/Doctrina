// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'authentication_store.dart';

// **************************************************************************
// StoreGenerator
// **************************************************************************

// ignore_for_file: non_constant_identifier_names, unnecessary_brace_in_string_interps, unnecessary_lambdas, prefer_expression_function_bodies, lines_longer_than_80_chars, avoid_as, avoid_annotating_with_dynamic

mixin _$AuthenticationStore on _AuthenticationStore, Store {
  Computed<bool> _$hasCurrentUserComputed;

  @override
  bool get hasCurrentUser =>
      (_$hasCurrentUserComputed ??= Computed<bool>(() => super.hasCurrentUser,
              name: '_AuthenticationStore.hasCurrentUser'))
          .value;
  Computed<bool> _$isAdminComputed;

  @override
  bool get isAdmin => (_$isAdminComputed ??= Computed<bool>(() => super.isAdmin,
          name: '_AuthenticationStore.isAdmin'))
      .value;

  final _$userAtom = Atom(name: '_AuthenticationStore.user');

  @override
  User get user {
    _$userAtom.reportRead();
    return super.user;
  }

  @override
  set user(User value) {
    _$userAtom.reportWrite(value, super.user, () {
      super.user = value;
    });
  }

  final _$tokenAtom = Atom(name: '_AuthenticationStore.token');

  @override
  String get token {
    _$tokenAtom.reportRead();
    return super.token;
  }

  @override
  set token(String value) {
    _$tokenAtom.reportWrite(value, super.token, () {
      super.token = value;
    });
  }

  final _$setJWTInLocalStorageAsyncAction =
      AsyncAction('_AuthenticationStore.setJWTInLocalStorage');

  @override
  Future<void> setJWTInLocalStorage(String jwt) {
    return _$setJWTInLocalStorageAsyncAction
        .run(() => super.setJWTInLocalStorage(jwt));
  }

  final _$logoutAsyncAction = AsyncAction('_AuthenticationStore.logout');

  @override
  Future<void> logout() {
    return _$logoutAsyncAction.run(() => super.logout());
  }

  @override
  String toString() {
    return '''
user: ${user},
token: ${token},
hasCurrentUser: ${hasCurrentUser},
isAdmin: ${isAdmin}
    ''';
  }
}
