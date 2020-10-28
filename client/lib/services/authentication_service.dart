import 'dart:async';

import 'package:client/datas/responses/authentication_response.dart';
import 'package:client/http/http.dart';

final _http = Http();

class AuthenticationService {
  Future<AuthenticationResponse> loginAdmin(
    String email,
    String password,
  ) async {
    assert(email != null);
    assert(password != null);
    var res = await _http.post("authentication/signin",
        data: {"email": email, "password": password});
    AuthenticationResponse authResponse =
        AuthenticationResponse.fromJson(res.response);
    return authResponse;
  }
}
