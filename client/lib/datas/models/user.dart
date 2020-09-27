import 'package:equatable/equatable.dart';

class User extends Equatable {
  const User(
    this.id,
    this.username,
    this.email,
    this.role,
  );

  final int id;
  final String username;
  final String email;
  final int role;

  @override
  List<Object> get props => [id];

  factory User.fromJson(Map<String, dynamic> json) => User(
        json['id'] as int,
        json['username'] as String,
        json['email'] as String,
        json['role'] as int,
      );

  Map<String, dynamic> toJson(User instance) => <String, dynamic>{
        'id': instance.id,
        'username': instance.username,
        'email': instance.email,
        'role': instance.role,
      };
}

enum Role { admin, member }
