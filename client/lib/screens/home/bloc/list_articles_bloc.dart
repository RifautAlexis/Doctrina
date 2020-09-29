import 'dart:async';

import 'package:bloc/bloc.dart';
import 'package:client/datas/models/article.dart';
import 'package:client/services/article_service.dart';
import 'package:equatable/equatable.dart';
import 'package:meta/meta.dart';
import 'package:rxdart/rxdart.dart';

part 'list_articles_event.dart';
part 'list_articles_state.dart';

class ListArticlesBloc extends Bloc<ListArticlesEvent, ListArticlesState> {
  final ArticleService articleService;

  ListArticlesBloc({@required this.articleService})
      : super(ListArticlesInitial());

  @override
  Stream<Transition<ListArticlesEvent, ListArticlesState>> transformEvents(
    Stream<ListArticlesEvent> events,
    TransitionFunction<ListArticlesEvent, ListArticlesState> transitionFn,
  ) {
    return super.transformEvents(
      events.debounceTime(const Duration(milliseconds: 500)),
      transitionFn,
    );
  }

  @override
  Stream<ListArticlesState> mapEventToState(ListArticlesEvent event) async* {
    final currentState = state;
    print(event);

    if (event is ArticlesFetched) {
      try {
        if (currentState is ListArticlesInitial) {
          print("=> ListArticlesInitial");
          final articles = await _fetchArticles();
          yield ListArticlesSuccess(articles: articles);
          return;
        }
        if (currentState is ListArticlesSuccess) {
          print("=> ListArticlesSuccess");
          final articles = await _fetchArticles();
          yield articles.isEmpty
              ? {ListArticlesInitial(), print("!!!!! articles empty !!!!!")}
              : ListArticlesSuccess(articles: currentState.articles + articles);
        }
      } catch (_) {
        yield ListArticlesFailure();
      }
    }
  }

  Future<List<Article>> _fetchArticles() async {
    final articlesResponse = await articleService.getArticles();
    return articlesResponse.articles;
  }
}
