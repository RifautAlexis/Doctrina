import 'package:client/datas/models/user.dart';

class AuthenticationResponse {
  final User user;
  final String token;

  AuthenticationResponse({this.user, this.token});

  factory AuthenticationResponse.fromJson(Map<String, dynamic> response) {
    User user = User.fromJson(response["user"]);
    String token = response["token"];
    return AuthenticationResponse(
      user: user,
      token: token
    );
  }
}