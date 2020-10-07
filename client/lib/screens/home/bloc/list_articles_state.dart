part of 'list_articles_bloc.dart';

@immutable
abstract class ListArticlesState {
  const ListArticlesState();

  List<Object> get props => [];
}

class ListArticlesInitial extends ListArticlesState {}

class ListArticlesFailure extends ListArticlesState {}

class ListArticlesLoadInProgress extends ListArticlesState {}

class ListArticlesSuccess extends ListArticlesState {
  final List<Article> articles;

  const ListArticlesSuccess({this.articles});

  List<Object> get props => [articles];
}