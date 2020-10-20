import 'package:client/mobx/authentication_store.dart';
import 'package:client/routes.dart';
import 'package:client/utils/configEnv.dart';
import 'package:flutter/material.dart';
import 'package:client/theme/style.dart';
import 'package:get/get.dart';
import 'package:provider/provider.dart';

class MyApp extends StatelessWidget {

  @override
  Widget build(BuildContext context) {
    ConfigEnv env = new ConfigEnv();

    return MultiProvider(
      providers: [
        Provider<AuthenticationStore>(create: (_) => AuthenticationStore())
      ],
      child: GetMaterialApp(
          title: env.get("appName"),
          theme: appTheme,
          initialRoute: '/',
          onGenerateRoute: FluroRouter.router.generator),
    );
  }
}
