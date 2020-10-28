import 'dart:io';

import 'package:client/datas/http_error.dart';
import 'package:client/datas/responses/api_response.dart';
import 'package:client/http/http_error_interceptor.dart';
import 'package:client/http/network_exceptions.dart';
import 'package:client/utils/configEnv.dart';
import 'package:dio/dio.dart';
import 'dart:html' as html;

class Http {
  static final Http _instance = Http._internal();
  Dio _dio;
  BaseOptions _options;
  ConfigEnv env = new ConfigEnv();

  factory Http() {
    return _instance;
  }

  Dio getDioClient() {
    return _dio;
  }

  Http._internal() {
    _options = BaseOptions(
      baseUrl: env.get("API_URL"),
      followRedirects: false,
      validateStatus: (status) {
        return httpStatusValide.contains(status);
      },
    );

    _dio = Dio(_options);

    _dio.interceptors
        .add(InterceptorsWrapper(onRequest: (RequestOptions options) async {
      _dio.interceptors.requestLock.lock();
      String token = html.window.localStorage['token'];

      if (token != null) {
        options.headers["Authorization"] = "Bearer " + token;
      }

      _dio.interceptors.requestLock.unlock();
      return options;
    }));

    _dio.interceptors.add(HttpErrorInterceptor());
  }

  Future<ApiResponse> get(
    String uri, {
    Map<String, dynamic> queryParameters,
    Options options,
    CancelToken cancelToken,
    ProgressCallback onReceiveProgress,
  }) async {
    try {
      var response = await _dio.get(
        uri,
        queryParameters: queryParameters,
        options: options,
        cancelToken: cancelToken,
        onReceiveProgress: onReceiveProgress,
      );
      return ApiResponse(response: response.data);
    } on DioError catch (failure) {
      var httpError = failure.error as HttpError;
      throw httpError;
    } catch (failure) {
      throw failure;
    }
  }

  Future<ApiResponse> post(
    String uri, {
    data,
    Map<String, dynamic> queryParameters,
    Options options,
    CancelToken cancelToken,
    ProgressCallback onSendProgress,
    ProgressCallback onReceiveProgress,
  }) async {
    try {
      var response = await _dio.post(
        uri,
        data: data,
        queryParameters: queryParameters,
        options: options,
        cancelToken: cancelToken,
        onSendProgress: onSendProgress,
        onReceiveProgress: onReceiveProgress,
      );
      return ApiResponse(response: response.data);
    } on DioError catch (failure) {
      var httpError = failure.error as HttpError;
      throw httpError;
    } catch (failure) {
      throw failure;
    }
  }

  Future<ApiResponse> patch(
    String uri, {
    data,
    Map<String, dynamic> queryParameters,
    Options options,
    CancelToken cancelToken,
    ProgressCallback onSendProgress,
    ProgressCallback onReceiveProgress,
  }) async {
    try {
      var response = await _dio.patch(
        uri,
        data: data,
        queryParameters: queryParameters,
        options: options,
        cancelToken: cancelToken,
        onSendProgress: onSendProgress,
        onReceiveProgress: onReceiveProgress,
      );
      return ApiResponse(response: response.data);
    } on DioError catch (failure) {
      var httpError = failure.error as HttpError;
      throw httpError;
    } catch (failure) {
      throw failure;
    }
  }

  Future<ApiResponse> delete(
    String uri, {
    data,
    Map<String, dynamic> queryParameters,
    Options options,
    CancelToken cancelToken,
  }) async {
    try {
      var response = await _dio.delete(
        uri,
        data: data,
        queryParameters: queryParameters,
        options: options,
        cancelToken: cancelToken,
      );
      return ApiResponse(response: response.data);
    } on DioError catch (failure) {
      var httpError = failure.error as HttpError;
      throw httpError;
    } catch (failure) {
      throw failure;
    }
  }
}
