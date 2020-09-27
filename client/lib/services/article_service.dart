import 'package:client/datas/responses/articles_response.dart';
import 'package:client/http/http.dart';

final _http = Http();

class ArticleService {
  Future<ArticlesResponse> getArticles() async {
    var res = await _http.get("article");
    ArticlesResponse articlesResponse = ArticlesResponse.fromJson(res.response);
    return articlesResponse;
  }
}
