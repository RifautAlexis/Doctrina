// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'articles_store.dart';

// **************************************************************************
// StoreGenerator
// **************************************************************************

// ignore_for_file: non_constant_identifier_names, unnecessary_brace_in_string_interps, unnecessary_lambdas, prefer_expression_function_bodies, lines_longer_than_80_chars, avoid_as, avoid_annotating_with_dynamic

mixin _$ArticlesStore on _ArticlesStore, Store {
  Computed<bool> _$hasErrorComputed;

  @override
  bool get hasError => (_$hasErrorComputed ??=
          Computed<bool>(() => super.hasError, name: '_ArticlesStore.hasError'))
      .value;
  Computed<bool> _$isLoadingComputed;

  @override
  bool get isLoading =>
      (_$isLoadingComputed ??= Computed<bool>(() => super.isLoading,
              name: '_ArticlesStore.isLoading'))
          .value;
  Computed<bool> _$hasResultsComputed;

  @override
  bool get hasResults =>
      (_$hasResultsComputed ??= Computed<bool>(() => super.hasResults,
              name: '_ArticlesStore.hasResults'))
          .value;

  final _$fetchArticlesFutureAtom =
      Atom(name: '_ArticlesStore.fetchArticlesFuture');

  @override
  ObservableFuture<List<Article>> get fetchArticlesFuture {
    _$fetchArticlesFutureAtom.reportRead();
    return super.fetchArticlesFuture;
  }

  @override
  set fetchArticlesFuture(ObservableFuture<List<Article>> value) {
    _$fetchArticlesFutureAtom.reportWrite(value, super.fetchArticlesFuture, () {
      super.fetchArticlesFuture = value;
    });
  }

  final _$fetchArticlesAsyncAction =
      AsyncAction('_ArticlesStore.fetchArticles');

  @override
  Future<dynamic> fetchArticles() {
    return _$fetchArticlesAsyncAction.run(() => super.fetchArticles());
  }

  @override
  String toString() {
    return '''
fetchArticlesFuture: ${fetchArticlesFuture},
hasError: ${hasError},
isLoading: ${isLoading},
hasResults: ${hasResults}
    ''';
  }
}
