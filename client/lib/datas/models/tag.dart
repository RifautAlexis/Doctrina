import 'package:equatable/equatable.dart';
import 'package:flutter_tagging/flutter_tagging.dart';

class Tag extends Taggable { // Equatable
  const Tag(
    this.id,
    this.name,
    this.createdAt,
    this.updatedAt,
  );

  final int id;
  final String name;
  final DateTime createdAt;
  final DateTime updatedAt;

  @override
  List<Object> get props => [id];

  factory Tag.fromJson(Map<String, dynamic> json) => Tag(
        json['id'] as int,
        json['name'] as String,
        DateTime.parse(json['createdAt'] as String),
        DateTime.parse(json['updatedAt'] as String),
      );

  Map<String, dynamic> toJson(Tag instance) => <String, dynamic>{
        'id': instance.id,
        'name': instance.name,
        'createdAt': instance.createdAt.toIso8601String(),
        'updatedAt': instance.updatedAt.toIso8601String(),
      };
}
