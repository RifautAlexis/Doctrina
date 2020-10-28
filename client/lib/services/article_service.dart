import 'dart:io';

import 'package:client/datas/models/article.dart';
import 'package:client/datas/responses/article_response.dart';
import 'package:client/datas/responses/articles_response.dart';
import 'package:client/datas/responses/boolean_response.dart';
import 'package:client/datas/responses/id_response.dart';
import 'package:client/http/http.dart';

final _http = Http();

class ArticleService {
  Future<List<Article>> getArticles() async {
    var res = await _http.get("article");
    ArticlesResponse articlesResponse = ArticlesResponse.fromJson(res.response);
    return articlesResponse.articles;
  }

  Future<Article> getArticle(int articleId) async {
    var res = await _http.get("article/" + articleId.toString());
    ArticleResponse articleResponse = ArticleResponse.fromJson(res.response);
    return articleResponse.articleDetails;
  }

  Future<bool> isUniqueTitle(String title) async {
    var res = await _http.post("article/isUniqueTitle", data: {"Title": title});
    BooleanResponse articleResponse = BooleanResponse.fromJson(res.response);
    return articleResponse.value;
  }

  Future<int> createArticle(String title, String description, String content,
      List<int> tagIds) async {
    var res = await _http.post("article/createArticle",
        data: {
          "title": title,
          "description": description,
          "content": content,
          "tagIds": tagIds
        },
        queryParameters: null);
    IdResponse idResponse = IdResponse.fromJson(res.response);
    return idResponse.id;
  }
}
