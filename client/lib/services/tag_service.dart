import 'package:client/datas/responses/tags_response.dart';
import 'package:client/http/http.dart';

final _http = Http();

class TagService {
  Future<TagsResponse> getTags() async {
    var res = await _http.get("tag");
    TagsResponse tagsResponse = TagsResponse.fromJson(res.response);
    return tagsResponse;
  }
}
