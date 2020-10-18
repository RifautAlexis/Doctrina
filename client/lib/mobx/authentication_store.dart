import 'package:client/datas/models/user.dart';
import 'package:mobx/mobx.dart';
import 'package:validators/validators.dart';

part 'authentication_store.g.dart';

class AuthenticationStore = _AuthenticationStore with _$AuthenticationStore;

abstract class _AuthenticationStore with Store {
  _AuthenticationStore();

  @observable
  User user;

  @observable
  String token = '';

  @computed
  bool get hasCurrentUser =>
      user != null && !isNull(token) && token.isNotEmpty;
}
