import 'package:client/components/snackbar.dart';
import 'package:client/datas/http_error.dart';
import 'package:client/datas/models/article.dart';
import 'package:client/services/article_service.dart';
import 'package:flutter/material.dart';
import 'package:mobx/mobx.dart';

part 'articles_store.g.dart';

class ArticlesStore = _ArticlesStore with _$ArticlesStore;

abstract class _ArticlesStore with Store {
  _ArticlesStore({@required this.articleService});

  final ArticleService articleService;

  List<Article> articles = [];

  @observable
  ObservableFuture<List<Article>> fetchArticlesFuture = emptyResponse;

  @computed
  bool get hasError => fetchArticlesFuture.status == FutureStatus.rejected;

  @computed
  bool get isLoading => fetchArticlesFuture.status == FutureStatus.pending;

  @computed
  bool get hasResults =>
      fetchArticlesFuture != emptyResponse &&
      fetchArticlesFuture.status == FutureStatus.fulfilled;

  static ObservableFuture<List<Article>> emptyResponse =
      ObservableFuture.value([]);

  @action
  Future fetchArticles() async {
    try {
      final articles = articleService.getArticles();
      fetchArticlesFuture = ObservableFuture(articles);

      this.articles = await articles;
    } on HttpError catch (failure) {
      Snackbar.createError(message: failure.errorMesage);
    } catch (failure) {
      Snackbar.createError();
    }
  }
}
