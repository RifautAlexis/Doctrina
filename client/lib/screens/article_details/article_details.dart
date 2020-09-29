import 'package:client/components/frame_page.dart';
import 'package:client/screens/article_details/bloc/article_details_bloc.dart';
import 'package:client/services/article_service.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';

class ArticleDetails extends StatelessWidget {
  final int articleId;
  const ArticleDetails({Key key, @required this.articleId}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    print("ARTICLEID => " + articleId.toString());
    return FramePage(
      body: BlocProvider(
        create: (context) => ArticleDetailsBloc(articleService: ArticleService())
          ..add(ArticleDetailsFetched(articleId)),
        child: ArticleDetailsPage(),
      ),
    );
  }
}

class ArticleDetailsPage extends StatefulWidget {
  @override
  _ArticleDetailsPageState createState() => _ArticleDetailsPageState();
}

class _ArticleDetailsPageState extends State<ArticleDetailsPage> {
  ArticleDetailsBloc _articleDetailsBloc;

  @override
  void initState() {
    super.initState();
    _articleDetailsBloc = BlocProvider.of<ArticleDetailsBloc>(context);
  }

  @override
  Widget build(BuildContext context) {
    return BlocBuilder<ArticleDetailsBloc, ArticleDetailsState>(
      builder: (context, state) {
        if (state is ArticleDetailsInitial) {
          return Center(
            child: CircularProgressIndicator(),
          );
        }
        if (state is ArticleDetailsFailure) {
          return Center(
            child: Text('failed to fetch articles'),
          );
        }
        if (state is ArticleDetailsSuccess) {
          if (state.article == null) {
            return Center(
              child: Text('no articles'),
            );
          }
          final article = state.article;
          return Column(
            children: [
              Text(article.title),
              Text(article.content),
            ],
          );
        }
      },
    );
  }
}
