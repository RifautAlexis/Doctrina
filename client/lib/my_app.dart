import 'package:client/utils/configEnv.dart';
import 'package:flutter/material.dart';
import 'package:client/routes.dart';
import 'package:client/theme/style.dart';
import 'package:get/get.dart';
import 'package:global_configuration/global_configuration.dart';

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
  ConfigEnv env = new ConfigEnv();
    
    return MaterialApp(
      title: env.get("appName"),
      theme: appTheme,
      initialRoute: '/',
      routes: routes,
    );
  }
}