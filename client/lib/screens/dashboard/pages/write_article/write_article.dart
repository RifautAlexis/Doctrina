import 'package:client/mobx/tags_store.dart';
import 'package:client/screens/dashboard/dashboard.dart';
import 'package:client/screens/dashboard/pages/write_article/components/form_write_article/form_write_article.dart';
import 'package:client/screens/dashboard/pages/write_article/components/preview_content/preview_content.dart';
import 'package:client/screens/dashboard/pages/write_article/mobx/form_write_article_store.dart';
import 'package:client/services/article_service.dart';
import 'package:client/services/tag_service.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class WriteArticle extends StatefulWidget {
  const WriteArticle({Key key}) : super(key: key);

  @override
  _WriteArticleState createState() => _WriteArticleState();
}

class _WriteArticleState extends State<WriteArticle> {

  @override
  void initState() {
    super.initState();
  }

  @override
  void dispose() {
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Dashboard(
        body: MultiProvider(
      providers: [
        Provider<TagService>(create: (_) => TagService()),
        ProxyProvider<TagService, TagsStore>(
            update: (_, tagService, __) =>
                TagsStore(tagService: tagService)..fetchTags()),
        Provider<ArticleService>(create: (_) => ArticleService()),
        ProxyProvider<ArticleService, FormWriteArticleStore>(
            update: (_, articleService, __) =>
                FormWriteArticleStore(articleService: articleService))
      ],
      child: _buildPage(context),
    ));
  }

  Widget _buildPage(BuildContext context) {
    return Column(children: [
      FormWriteArticle(),
      Divider(
        thickness: 3.0,
      ),
      Expanded(child: PreviewContent())
    ]);
  }
}