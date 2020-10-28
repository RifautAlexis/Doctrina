import 'package:client/datas/models/article.dart';

class ArticleResponse {
  final Article articleDetails;

  ArticleResponse({this.articleDetails});

  factory ArticleResponse.fromJson(Map<String, dynamic> response) {
    Article articleDetails = Article();
    articleDetails = Article.fromJson(response["article"]);
    return ArticleResponse(
      articleDetails: articleDetails,
    );
  }
}
