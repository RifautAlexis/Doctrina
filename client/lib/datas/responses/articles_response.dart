import 'package:client/datas/models/article.dart';

class ArticlesResponse {
  final List<Article> articles;

  ArticlesResponse({this.articles});

  factory ArticlesResponse.fromJson(Map<String, dynamic> response) {
    List<Article> articles = List<Article>();
    articles = List<Article>.from(response["articles"].map((x) => Article.fromJson(x)));
    return ArticlesResponse(
      articles: articles,
    );
  }
}
