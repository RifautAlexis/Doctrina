import 'package:client/datas/models/tag.dart';

class TagsResponse {
  final List<Tag> tags;

  TagsResponse({this.tags});

  factory TagsResponse.fromJson(Map<String, dynamic> response) {
    List<Tag> tags = List<Tag>();
    tags = List<Tag>.from(response["tags"].map((x) => Tag.fromJson(x)));
    return TagsResponse(
      tags: tags,
    );
  }
}
