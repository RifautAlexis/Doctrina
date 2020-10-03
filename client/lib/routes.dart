import 'package:client/screens/article_details/article_details.dart';
import 'package:client/screens/dashboard/pages/write_article/write_article.dart';
import 'package:client/screens/home/home.dart';
import 'package:fluro/fluro.dart' as fluro;
import 'package:fluro/fluro.dart';
import 'package:flutter/material.dart';

class FluroRouter {
  static fluro.Router router = fluro.Router();

  static void setupRouter() {
    router.define('/',
        handler: Handler(handlerFunc: (context, params) => Home()));

    router.define('articleDetails/:id', handler: Handler(
        handlerFunc: (BuildContext context, Map<String, dynamic> params) {
      final id = int.parse(params['id'][0]);
      return ArticleDetails(articleId: id);
    }));

    // router.define('dashboard', handler: Handler(
    //     handlerFunc: (BuildContext context, Map<String, dynamic> params) => Dashboard(body: Text("AAAA"))));

    router.define('dashboard/write', handler: Handler(
        handlerFunc: (BuildContext context, Map<String, dynamic> params) => WriteArticle()));
  }
}
