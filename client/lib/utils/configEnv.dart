import 'package:flutter/services.dart' show rootBundle;
import 'dart:convert';

class ConfigEnv {
  static ConfigEnv _singleton = ConfigEnv._internal();
  Map<String, dynamic> appConfig = Map<String, dynamic>();

  factory ConfigEnv() {
    return _singleton;
  }

  ConfigEnv._internal();
  
  dynamic get(String key) => appConfig[key];
  
  Future<ConfigEnv> loadFromAsset(String name) async {
    String content = await rootBundle.loadString("env/env_dev.json");
    Map<String, dynamic> configAsMap = json.decode(content);
    appConfig.addAll(configAsMap);
    return _singleton;
  }
}