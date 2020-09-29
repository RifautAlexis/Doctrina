import 'package:client/datas/responses/article_response.dart';
import 'package:client/datas/responses/articles_response.dart';
import 'package:client/http/http.dart';

final _http = Http();

class ArticleService {
  Future<ArticlesResponse> getArticles() async {
    print("getArticles()");
    var res = await _http.get("article");
    ArticlesResponse articlesResponse = ArticlesResponse.fromJson(res.response);
    return articlesResponse;
  }

  Future<ArticleResponse> getArticle(int articleId) async {
    print("getArticle(int articleId) => " + articleId.toString());
    var res = await _http.get("article/" + articleId.toString());
    print("res");
    ArticleResponse articleResponse = ArticleResponse.fromJson(res.response);
    print(articleResponse);
    return articleResponse;
  }
}
