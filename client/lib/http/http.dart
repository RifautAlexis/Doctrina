import 'package:client/datas/responses/api_response.dart';
import 'package:client/utils/configEnv.dart';
import 'package:dio/dio.dart';

class Http {
  static final Http _instance = Http._internal();
  Dio _dio;
  BaseOptions _options;
  ConfigEnv env = new ConfigEnv();

  // static final authBloc = AuthBloc();

  factory Http() {
    return _instance;
  }

  Dio getDioClient() {
    return _dio;
  }

  Http._internal() {
    _options = BaseOptions(
      baseUrl: env.get("apiUrl"),
      followRedirects: false,
      validateStatus: (status) {
        return status < 500;
      },
    );

    _dio = Dio(_options);

    _dio.interceptors
        .add(InterceptorsWrapper(onRequest: (RequestOptions options) async {
      _dio.interceptors.requestLock.lock();
      // String token = await authBloc.getToken();

      // if (token != null) {
      //   options.headers["Authorization"] = "Bearer " + token;
      // }

      _dio.interceptors.requestLock.unlock();
      return options;
    }));
  }

  Future<ApiResponse> get(String url, [Map<String, dynamic> params]) async {
    final requestResponse =
        await _dio.get(url, queryParameters: params == null ? {} : params);
    return ApiResponse(response: requestResponse.data);
  }

  Future<dynamic> post(String url,
      {dynamic data,
      Map<String, dynamic> queryParameters,
      void Function(int, int) onSendProgress}) async {
    final requestResponse = await _dio.post(url,
        data: data == null ? {} : data,
        queryParameters: queryParameters == null ? {} : queryParameters,
        onSendProgress: onSendProgress);
    return ApiResponse(response: requestResponse.data);
  }

  Future<dynamic> delete(String url, [Map<String, dynamic> params]) async {
    final requestResponse =
        await _dio.delete(url, queryParameters: params == null ? {} : params);
    return ApiResponse(response: requestResponse.data);
  }

  Future<dynamic> put(String url,
      {dynamic data,
      Map<String, dynamic> queryParameters,
      void Function(int, int) onSendProgress}) async {
    final requestResponse = await _dio.put(url,
        data: data == null ? {} : data,
        queryParameters: queryParameters == null ? {} : queryParameters,
        onSendProgress: onSendProgress);
    return ApiResponse(response: requestResponse.data);
  }
}
