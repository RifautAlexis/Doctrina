import 'package:client/routes.dart';
import 'package:client/utils/configEnv.dart';
import 'package:flutter/material.dart';
import 'package:client/my_app.dart';

Future main() async {
  WidgetsFlutterBinding.ensureInitialized();
  FluroRouter.setupRouter();
  ConfigEnv().loadFromAsset();

  runApp(MyApp());
}
