// part of 'home_bloc.dart';

// @immutable
// abstract class HomeState {}

// class HomeInitial extends HomeState {}

part of 'list_articles_bloc.dart';

@immutable
abstract class ListArticlesState extends Equatable {
  const ListArticlesState();

  @override
  List<Object> get props => [];
}

class ListArticlesInitial extends ListArticlesState {}

class ListArticlesFailure extends ListArticlesState {}

class ListArticlesLoadInProgress extends ListArticlesState {}

class ListArticlesSuccess extends ListArticlesState {
  final List<Article> articles;

  const ListArticlesSuccess({this.articles});

  @override
  List<Object> get props => [articles];

  @override
  String toString() => 'ListArticleLoadSuccess { articles: $articles }';
}