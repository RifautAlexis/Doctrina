import 'package:client/components/frame_page.dart';
import 'package:client/screens/article_details/mobx/article_details_store.dart';
import 'package:client/services/article_service.dart';
import 'package:flutter/material.dart';
import 'package:flutter_mobx/flutter_mobx.dart';
import 'package:flutter_widget_from_html_core/flutter_widget_from_html_core.dart';
import 'package:intl/intl.dart';
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
        var quarterWidth = MediaQuery.of(context).size.width / 6;
        String dateToDisplay = '';
        if (articleDetails.createdAt.isAtSameMomentAs(articleDetails.updatedAt)) {
          var dateFormat = DateFormat('dd-MM-yyyy').format(articleDetails.createdAt);
          dateToDisplay = 'Publié le $dateFormat';
        } else {
          var dateFormat = DateFormat('dd-MM-yyyy').format(articleDetails.updatedAt);
          dateToDisplay = 'Mise à jour le $dateFormat';
        }
        return SingleChildScrollView(
          child: Padding(
            padding: EdgeInsets.fromLTRB(quarterWidth, 10.0, quarterWidth, 0.0),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(
                  articleDetails.title,
                  style: const TextStyle(
                    fontSize: 24.0,
                    fontWeight: FontWeight.bold,
                  ),
                ),
                SizedBox(height: 15.0),
                Text(dateToDisplay),
                SizedBox(height: 25.0),
                ListView(
                    shrinkWrap: true,
                    children: [HtmlWidget(articleDetails.content)])
              ],
            ),
          ),
        );
      }
      return Center(
        child: CircularProgressIndicator(),
      );
    });
  }
}
