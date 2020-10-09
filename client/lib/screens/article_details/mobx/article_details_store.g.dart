// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'article_details_store.dart';

// **************************************************************************
// StoreGenerator
// **************************************************************************

// ignore_for_file: non_constant_identifier_names, unnecessary_brace_in_string_interps, unnecessary_lambdas, prefer_expression_function_bodies, lines_longer_than_80_chars, avoid_as, avoid_annotating_with_dynamic

mixin _$ArticleDetailsStore on _ArticleDetailsStore, Store {
  Computed<bool> _$hasErrorComputed;

  @override
  bool get hasError =>
      (_$hasErrorComputed ??= Computed<bool>(() => super.hasError,
              name: '_ArticleDetailsStore.hasError'))
          .value;
  Computed<bool> _$isLoadingComputed;

  @override
  bool get isLoading =>
      (_$isLoadingComputed ??= Computed<bool>(() => super.isLoading,
              name: '_ArticleDetailsStore.isLoading'))
          .value;
  Computed<bool> _$hasResultsComputed;

  @override
  bool get hasResults =>
      (_$hasResultsComputed ??= Computed<bool>(() => super.hasResults,
              name: '_ArticleDetailsStore.hasResults'))
          .value;

  final _$fetchArticleDetailsFutureAtom =
      Atom(name: '_ArticleDetailsStore.fetchArticleDetailsFuture');

  @override
  ObservableFuture<Article> get fetchArticleDetailsFuture {
    _$fetchArticleDetailsFutureAtom.reportRead();
    return super.fetchArticleDetailsFuture;
  }

  @override
  set fetchArticleDetailsFuture(ObservableFuture<Article> value) {
    _$fetchArticleDetailsFutureAtom
        .reportWrite(value, super.fetchArticleDetailsFuture, () {
      super.fetchArticleDetailsFuture = value;
    });
  }

  final _$fetchArticleDetailsAsyncAction =
      AsyncAction('_ArticleDetailsStore.fetchArticleDetails');

  @override
  Future<dynamic> fetchArticleDetails(int articleId) {
    return _$fetchArticleDetailsAsyncAction
        .run(() => super.fetchArticleDetails(articleId));
  }

  @override
  String toString() {
    return '''
fetchArticleDetailsFuture: ${fetchArticleDetailsFuture},
hasError: ${hasError},
isLoading: ${isLoading},
hasResults: ${hasResults}
    ''';
  }
}
