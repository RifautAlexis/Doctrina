import 'package:client/datas/models/user.dart';
import 'package:mobx/mobx.dart';
import 'package:validators/validators.dart';
import 'dart:html' as html;

part 'authentication_store.g.dart';

class AuthenticationStore = _AuthenticationStore with _$AuthenticationStore;

abstract class _AuthenticationStore with Store {
  _AuthenticationStore();

  @observable
  User user;

  @observable
  String token = '';

  @computed
  bool get hasCurrentUser {
    return user != null && !isNull(token) && token.isNotEmpty;
  }
      
  
  @action
  Future<void> setJWTInLocalStorage(String jwt) async {
      html.window.localStorage['token'] = jwt;
  }
  
  @action
  Future<void> logout() async {
      html.window.localStorage['token'] = '';
      user = null;
      token = '';
  }
}
