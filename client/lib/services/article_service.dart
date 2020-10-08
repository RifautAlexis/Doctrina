import 'package:client/datas/models/article.dart';
import 'package:client/datas/responses/article_response.dart';
import 'package:client/datas/responses/articles_response.dart';
import 'package:client/datas/responses/boolean_response.dart';
import 'package:client/http/http.dart';

final _http = Http();

class ArticleService {
  Future<List<Article>> getArticles() async {
    var res = await _http.get("article");
    ArticlesResponse articlesResponse = ArticlesResponse.fromJson(res.response);
    return articlesResponse.articles;
  }

  Future<ArticleResponse> getArticle(int articleId) async {
    var res = await _http.get("article/" + articleId.toString());
    ArticleResponse articleResponse = ArticleResponse.fromJson(res.response);
    return articleResponse;
  }

  Future<BooleanResponse> isUniqueTitle(String title) async {
    var res = await _http.post("article/isUniqueTitle" + title);
    BooleanResponse articleResponse = BooleanResponse.fromJson(res.response);
    return articleResponse;
  }

  Future<BooleanResponse> createArticle(String title) async {
    var res = await _http.post("article/isUniqueTitle" + title);
    BooleanResponse articleResponse = BooleanResponse.fromJson(res.response);
    return articleResponse;
  }
}
