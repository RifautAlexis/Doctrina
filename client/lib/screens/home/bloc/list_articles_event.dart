part of 'list_articles_bloc.dart';

@immutable
abstract class ListArticlesEvent {
  const ListArticlesEvent();

  List<Object> get props => [];
}

class ArticlesFetched extends ListArticlesEvent {}
