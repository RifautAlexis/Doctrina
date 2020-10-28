import 'package:client/datas/models/tag.dart';
import 'package:client/datas/responses/tags_response.dart';
import 'package:client/http/http.dart';

final _http = Http();

class TagService {
  Future<List<Tag>> getTags() async {
    var res = await _http.get("tag");
    TagsResponse tagsResponse = TagsResponse.fromJson(res.response);
    return tagsResponse.tags;
  }
}
