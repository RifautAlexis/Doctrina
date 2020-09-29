import 'package:client/routes.dart';
import 'package:client/utils/configEnv.dart';
import 'package:flutter/material.dart';
import 'package:client/theme/style.dart';

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
  ConfigEnv env = new ConfigEnv();
    
    return MaterialApp(
      title: env.get("appName"),
      theme: appTheme,
      initialRoute: '/',
      onGenerateRoute: FluroRouter.router.generator
    );
  }
}