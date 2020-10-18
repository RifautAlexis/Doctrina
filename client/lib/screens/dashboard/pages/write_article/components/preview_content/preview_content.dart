import 'package:client/screens/dashboard/pages/write_article/mobx/form_write_article_store.dart';
import 'package:flutter/material.dart';
import 'package:flutter_mobx/flutter_mobx.dart';
import 'package:flutter_widget_from_html_core/flutter_widget_from_html_core.dart';
import 'package:provider/provider.dart';

class PreviewContent extends StatelessWidget {
  const PreviewContent({Key key}) : super(key: key);
  
  @override
  Widget build(BuildContext context) {
    final formAWStore = Provider.of<FormWriteArticleStore>(context);
    return Observer(builder: (_) {
      if (!formAWStore.hasNoContent) {
        return ListView(
            shrinkWrap: true, children: [HtmlWidget(formAWStore.content)]);
      }
      return Center(child: Text("Nothing to preview"));
    });
  }
}
