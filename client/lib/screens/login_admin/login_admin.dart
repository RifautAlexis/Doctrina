import 'package:client/components/frame_page.dart';
import 'package:client/components/snackbar.dart';
import 'package:client/mobx/authentication_store.dart';
import 'package:client/screens/login_admin/mobx/form_login_admin_store.dart';
import 'package:client/services/authentication_service.dart';
import 'package:flutter/material.dart';
import 'package:flutter_mobx/flutter_mobx.dart';
import 'package:provider/provider.dart';

class LoginAdmin extends StatelessWidget {
  const LoginAdmin({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final authStore = Provider.of<AuthenticationStore>(context);
    final FormLoginAdminStore formLAStore = FormLoginAdminStore(
        authStore: authStore, authService: AuthenticationService());

    return FramePage(
        body: Form(
      child: Padding(
        padding: const EdgeInsets.all(8),
        child: Column(
          children: <Widget>[
            Observer(
              builder: (_) => TextField(
                onChanged: (value) => formLAStore.email = value,
                decoration: InputDecoration(
                    labelText: 'Email',
                    hintText: 'Enter your email',
                    errorText: formLAStore.error.email),
              ),
            ),
            Observer(
              builder: (_) => TextField(
                onChanged: (value) => formLAStore.password = value,
                obscureText: true,
                decoration: InputDecoration(
                    labelText: 'Password',
                    hintText: 'Enter your password',
                    errorText: formLAStore.error.password),
              ),
            ),
            RaisedButton(
                onPressed: () async {
                  var validate = await formLAStore.validateAllFields();
                  if (validate) {
                    await formLAStore.loginAdmin();
                    if (formLAStore.loginError) {
                      return Snackbar.createError(
                          message: "Some fields aren't conform !");
                    // } else if (formLAStore.loginPending) {
                    //   return Center(child: CircularProgressIndicator());
                    } else if (formLAStore.loginSuccessful) {
                      return Navigator.of(context).pushNamed('/dashboard/write');
                    }
                  } else {
                    return Snackbar.createError(
                        message: "Some fields aren't conform !");
                  }
                },
                child: const Text('Login'))
          ],
        ),
      ),
    ));
  }
}
