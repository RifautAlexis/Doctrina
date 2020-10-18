import 'package:mobx/mobx.dart';

part 'form_login_admin_error_state.g.dart';

class FormLoginAdminErrorState = _FormLoginAdminErrorState with _$FormLoginAdminErrorState;

abstract class _FormLoginAdminErrorState with Store {
  @observable
  String email;

  @observable
  String password;

  @computed
  bool get hasErrors => email != null || password != null;
}
