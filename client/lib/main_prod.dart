import 'package:client/utils/configEnv.dart';
import 'package:flutter/material.dart';
import 'package:client/my_app.dart';

Future main() async {
  await ConfigEnv().loadFromAsset("env/env_dev.json");

  runApp(MyApp());
}
