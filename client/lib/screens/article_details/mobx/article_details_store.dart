import 'package:client/components/snackbar.dart';
import 'package:client/datas/http_error.dart';
import 'package:client/datas/models/article.dart';
import 'package:client/services/article_service.dart';
import 'package:flutter/material.dart';
import 'package:mobx/mobx.dart';

part 'article_details_store.g.dart';

class ArticleDetailsStore = _ArticleDetailsStore with _$ArticleDetailsStore;

abstract class _ArticleDetailsStore with Store {
  _ArticleDetailsStore({@required this.articleService});

  final ArticleService articleService;

  Article article = Article();

  @observable
  ObservableFuture<Article> fetchArticleDetailsFuture = emptyResponse;

  @computed
  bool get hasError =>
      fetchArticleDetailsFuture.status == FutureStatus.rejected;

  @computed
  bool get isLoading =>
      fetchArticleDetailsFuture.status == FutureStatus.pending;

  @computed
  bool get hasResults =>
      fetchArticleDetailsFuture != emptyResponse &&
      fetchArticleDetailsFuture.status == FutureStatus.fulfilled;

  static ObservableFuture<Article> emptyResponse =
      ObservableFuture.value(Article());

  @action
  Future fetchArticleDetails(int articleId) async {
    try {
      final article = articleService.getArticle(articleId);
      fetchArticleDetailsFuture = ObservableFuture(article);

      this.article = await article;
    } on HttpError catch (failure) {
      Snackbar.createError(message: failure.errorMesage);
    } catch (failure) {
      Snackbar.createError();
    }
  }
}
