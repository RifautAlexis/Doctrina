import 'package:client/datas/http_error.dart';
import 'package:dio/dio.dart';
import 'package:get/get.dart';

class HttpErrorInterceptor extends InterceptorsWrapper {
  @override
  Future onRequest(RequestOptions options) {
    return super.onRequest(options);
  }

  @override
  Future onResponse(Response response) {
    return super.onResponse(response);
  }

  @override
  Future<HttpError> onError(DioError err) {
    final httpError = HttpError.convert(err.response.data);
    switch (httpError.statusCode) {
      case 401:
        Get.toNamed('/');
        return Future.value();
        break;
      default:
      return Future.value(httpError);
    }
  }
}
