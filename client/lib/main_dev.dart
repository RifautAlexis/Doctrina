import 'package:client/routes.dart';
import 'package:client/utils/configEnv.dart';
import 'package:flutter/material.dart';
import 'package:client/my_app.dart';

Future main() async {
  WidgetsFlutterBinding.ensureInitialized();
  FluroRouter.setupRouter();
  await ConfigEnv().loadFromAsset("env/env_dev.json");

  runApp(MyApp());
}
