class ConfigEnv {
  static ConfigEnv _singleton = ConfigEnv._internal();
  Map<String, dynamic> appConfig = Map<String, dynamic>();

  factory ConfigEnv() {
    return _singleton;
  }

  ConfigEnv._internal();

  dynamic get(String key) => appConfig[key];

  ConfigEnv loadFromAsset() {
    const appName = String.fromEnvironment('APP_NAME');
    const apiUrl = String.fromEnvironment('API_URL');
    Map<String, dynamic> configAsMap = Map<String, dynamic>();
    configAsMap["APP_NAME"] = appName;
    configAsMap["API_URL"] = apiUrl;
    appConfig.addAll(configAsMap);
    return _singleton;
  }
}
