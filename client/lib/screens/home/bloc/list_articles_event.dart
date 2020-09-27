// part of 'home_bloc.dart';

// @immutable
// abstract class HomeEvent {}

part of 'list_articles_bloc.dart';

abstract class ListArticlesEvent extends Equatable {
  const ListArticlesEvent();

  @override
  List<Object> get props => [];
}

class ArticlesFetched extends ListArticlesEvent {}
