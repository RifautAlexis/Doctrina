import 'package:client/components/frame_page.dart';
import 'package:client/screens/article_details/mobx/article_details_store.dart';
import 'package:client/services/article_service.dart';
import 'package:flutter/material.dart';
import 'package:flutter_mobx/flutter_mobx.dart';
import 'package:provider/provider.dart';

class ArticleDetails extends StatelessWidget {
  final int articleId;
  const ArticleDetails({Key key, @required this.articleId}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return FramePage(
      body: MultiProvider(
        providers: [
          Provider<ArticleService>(create: (_) => ArticleService()),
          ProxyProvider<ArticleService, ArticleDetailsStore>(
              update: (_, articleService, __) =>
                  ArticleDetailsStore(articleService: articleService)
                    ..fetchArticleDetails(articleId))
        ],
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
  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    final articleDetailsStore = Provider.of<ArticleDetailsStore>(context);
    return Observer(builder: (_) {
      if (articleDetailsStore.hasError) {
        return Text('failed to fetch article details');
      } else if (articleDetailsStore.isLoading) {
        return Center(
          child: CircularProgressIndicator(),
        );
      } else if (articleDetailsStore.hasResults) {
        final articleDetails = articleDetailsStore.article;
        return Column(
          children: [
            Text(articleDetails.title),
            Text(articleDetails.content),
          ],
        );
      }
      return Center(
        child: CircularProgressIndicator(),
      );
    });
  }
}
