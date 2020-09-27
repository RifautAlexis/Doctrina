import 'package:client/datas/models/tag.dart';
import 'package:client/datas/models/user.dart';
import 'package:equatable/equatable.dart';

class Article extends Equatable {
  const Article({
    this.id,
    this.title,
    this.content,
    this.description,
    this.author,
    this.tags,
    this.createdAt,
    this.updatedAt,
  });

  final int id;
  final String title;
  final String content;
  final String description;
  final User author;
  final List<Tag> tags;
  final DateTime createdAt;
  final DateTime updatedAt;

  @override
  List<Object> get props =>
      [id, title, content, description, author, tags, createdAt, updatedAt];

  factory Article.fromJson(Map<String, dynamic> json) => Article(
        id: json['id'] as int,
        title: json['title'] as String,
        content: json['content'] as String,
        description: json['description'] as String,
        author: User.fromJson(json['author'] as Map<String, dynamic>),
        tags: (json['tags'] as List)
            .map((e) => Tag.fromJson(e as Map<String, dynamic>))
            .toList(),
        createdAt: DateTime.parse(json['createdAt'] as String),
        updatedAt: DateTime.parse(json['updatedAt'] as String),
      );

  Map<String, dynamic> toJson(Article instance) => <String, dynamic>{
        'id': instance.id,
        'title': instance.title,
        'content': instance.content,
        'description': instance.description,
        'author': instance.author,
        'tags': instance.tags,
        'createdAt': instance.createdAt.toIso8601String(),
        'updatedAt': instance.updatedAt.toIso8601String(),
      };
}
