import 'dart:async';

import 'package:bloc/bloc.dart';
import 'package:client/datas/models/article.dart';
import 'package:client/services/article_service.dart';
import 'package:equatable/equatable.dart';
import 'package:meta/meta.dart';
import 'package:rxdart/rxdart.dart';

part 'article_details_event.dart';
part 'article_details_state.dart';

class ArticleDetailsBloc extends Bloc<ArticleDetailsEvent, ArticleDetailsState> {
  final ArticleService articleService;

  ArticleDetailsBloc({@required this.articleService})
      : super(ArticleDetailsInitial());

  @override
  Stream<Transition<ArticleDetailsEvent, ArticleDetailsState>> transformEvents(
    Stream<ArticleDetailsEvent> events,
    TransitionFunction<ArticleDetailsEvent, ArticleDetailsState> transitionFn,
  ) {
    return super.transformEvents(
      events.debounceTime(const Duration(milliseconds: 500)),
      transitionFn,
    );
  }

  @override
  Stream<ArticleDetailsState> mapEventToState(ArticleDetailsEvent event) async* {
    final currentState = state;

    if (event is ArticleDetailsFetched) {
      print("=> ArticleDetailsFetched");
      try {
        if (currentState is ArticleDetailsInitial) {
          print("=> ArticleDetailsInitial => " + event.articleId.toString());

          final article = await _fetchArticle(event.articleId);
          yield ArticleDetailsSuccess(article: article);
          return;
        }
        if (currentState is ArticleDetailsSuccess) {
          print("=> ArticleDetailsSuccess => " + event.articleId.toString());
          final article = await _fetchArticle(event.articleId);
          yield article == null
              ? {ArticleDetailsInitial(), print("!!!!! article details empty !!!!!")}
              : ArticleDetailsSuccess(article: article);
        }
      } catch (_) {
        yield ArticleDetailsFailure();
      }
    }
  }

  Future<Article> _fetchArticle(int articleId) async {
    print("_fetchArticle(int articleId) => " + articleId.toString());
    final articleDetailsResponse = await articleService.getArticle(articleId);
    return articleDetailsResponse.articleDetails;
  }
}
