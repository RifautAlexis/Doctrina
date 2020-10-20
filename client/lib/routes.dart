import 'package:client/mobx/authentication_store.dart';
import 'package:client/screens/about/about.dart';
import 'package:client/screens/article_details/article_details.dart';
import 'package:client/screens/dashboard/pages/write_article/write_article.dart';
import 'package:client/screens/home/home.dart';
import 'package:client/screens/knowledge_coffee/knowledge_coffee.dart';
import 'package:client/screens/login_admin/login_admin.dart';
import 'package:fluro/fluro.dart' as fluro;
import 'package:fluro/fluro.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

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

    router.define('/about',
        handler: Handler(
            handlerFunc: (BuildContext context, Map<String, dynamic> params) =>
                About()));

    router.define('/knowledge-coffee',
        handler: Handler(
            handlerFunc: (BuildContext context, Map<String, dynamic> params) =>
                KnowledgeCoffee()));

    router.define('admin', handler: Handler(
        handlerFunc: (BuildContext context, Map<String, dynamic> params) {
      final authStore = Provider.of<AuthenticationStore>(context);

      if (!authStore.hasCurrentUser) {
        return WriteArticle();
      } else {
        return LoginAdmin();
      }
    }));

    router.define('dashboard/write',
        handler: Handler(
            handlerFunc: (BuildContext context, Map<String, dynamic> params) =>
                guardMustBeAdmin(context, WriteArticle())));
  }

  static guardMustBeAdmin(BuildContext context, Widget screen) {
    assert(context != null);
    assert(screen != null);

    final authStore = Provider.of<AuthenticationStore>(context);

    if (!authStore.hasCurrentUser) {
      return LoginAdmin();
    } else {
      return WriteArticle();
    }
  }
}
