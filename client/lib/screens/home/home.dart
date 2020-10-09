import 'package:client/components/frame_page.dart';
import 'package:client/datas/models/article.dart';
import 'package:client/screens/home/mobx/articles_store.dart';
import 'package:flutter/material.dart';
import 'package:client/services/article_service.dart';
import 'package:flutter_mobx/flutter_mobx.dart';
import 'package:provider/provider.dart';

class Home extends StatefulWidget {
  Home({Key key}) : super(key: key);

  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return FramePage(
        body: MultiProvider(providers: [
      Provider<ArticleService>(create: (_) => ArticleService()),
      ProxyProvider<ArticleService, ArticlesStore>(
          update: (_, articleService, __) =>
              ArticlesStore(articleService: articleService)..fetchArticles())
    ], child: HomePage()));
  }
}

class HomePage extends StatefulWidget {
  @override
  _HomePageState createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    final articlesStore = Provider.of<ArticlesStore>(context);
    return Observer(builder: (_) {
      if (articlesStore.hasError) {
        return Text('failed to fetch articles');
      } else if (articlesStore.isLoading) {
        return Center(
          child: CircularProgressIndicator(),
        );
      } else if (articlesStore.hasResults) {
        return ListView.builder(
          itemBuilder: (BuildContext context, int index) {
            return ArticleWidget(article: articlesStore.articles[index]);
          },
          itemCount: articlesStore.articles.length,
        );
      }
      return Center(
        child: CircularProgressIndicator(),
      );
    });
  }
}

class ArticleWidget extends StatelessWidget {
  final Article article;

  const ArticleWidget({Key key, @required this.article}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListTile(
        leading: Text(
          '${article.id}',
          style: TextStyle(fontSize: 10.0),
        ),
        title: Text(article.title),
        isThreeLine: true,
        subtitle: Text(article.description),
        dense: true,
        onTap: () =>
            Navigator.of(context).pushNamed('/articleDetails/${article.id}'));
  }
}
