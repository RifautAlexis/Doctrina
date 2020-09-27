import 'package:client/components/frame_page.dart';
import 'package:client/datas/models/article.dart';
import 'package:client/screens/home/bloc/list_articles_bloc.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:global_configuration/global_configuration.dart';
import 'package:client/services/article_service.dart';

class Home extends StatefulWidget {
  Home({Key key}) : super(key: key);

  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return FramePage(
      body: BlocProvider(
        create: (context) => ListArticlesBloc(articleService: ArticleService())
          ..add(ArticlesFetched()),
        child: HomePage(),
      ),
    );
  }
}

class HomePage extends StatefulWidget {
  @override
  _HomePageState createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  final _scrollController = ScrollController();
  final _scrollThreshold = 200.0;
  ListArticlesBloc _listArticlesBloc;

  @override
  void initState() {
    super.initState();
    _scrollController.addListener(_onScroll);
    _listArticlesBloc = BlocProvider.of<ListArticlesBloc>(context);
  }

  @override
  Widget build(BuildContext context) {
    return BlocBuilder<ListArticlesBloc, ListArticlesState>(
      builder: (context, state) {
        if (state is ListArticlesInitial) {
          return Center(
            child: CircularProgressIndicator(),
          );
        }
        if (state is ListArticlesFailure) {
          return Center(
            child: Text('failed to fetch articles'),
          );
        }
        if (state is ListArticlesSuccess) {
          if (state.articles.isEmpty) {
            return Center(
              child: Text('no articles'),
            );
          }
          return ListView.builder(
            itemBuilder: (BuildContext context, int index) {
              return ArticleWidget(article: state.articles[index]);
            },
            itemCount: state.articles.length,
            controller: _scrollController,
          );
        }
      },
    );
  }

  @override
  void dispose() {
    _scrollController.dispose();
    super.dispose();
  }

  void _onScroll() {
    final maxScroll = _scrollController.position.maxScrollExtent;
    final currentScroll = _scrollController.position.pixels;
    if (maxScroll - currentScroll <= _scrollThreshold) {
      _listArticlesBloc.add(ArticlesFetched());
    }
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
      onTap: () => print("TAPED => " + article.id.toString()),
    );
  }
}
