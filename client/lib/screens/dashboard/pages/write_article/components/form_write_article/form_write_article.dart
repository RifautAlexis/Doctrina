import 'package:client/components/snackbar.dart';
import 'package:client/screens/dashboard/pages/write_article/components/tag_input_chips/tag_input_chips.dart';
import 'package:client/screens/dashboard/pages/write_article/mobx/form_write_article_store.dart';
import 'package:flutter/material.dart';
import 'package:flutter_mobx/flutter_mobx.dart';
import 'package:provider/provider.dart';

class FormWriteArticle extends StatelessWidget {
  FormWriteArticle({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final formAWStore = Provider.of<FormWriteArticleStore>(context);

    return Container(
      child: Column(
        children: [
          Observer(
              builder: (_) => TextField(
                  onChanged: (value) {
                    formAWStore.title = value;
                    formAWStore.validateTitle();
                  },
                  decoration: InputDecoration(
                      labelText: 'Title',
                      hintText: 'Enter a title',
                      prefixIcon: Icon(Icons.text_fields),
                      errorText: formAWStore.error.title))),
          Observer(
              builder: (_) => AnimatedOpacity(
                  child: const LinearProgressIndicator(),
                  duration: const Duration(milliseconds: 300),
                  opacity: formAWStore.isTitleCheckPending ? 1 : 0)),
          Observer(
              builder: (_) => TextField(
                  onChanged: (value) {
                    formAWStore.description = value;
                    formAWStore.validateDescription();
                  },
                  decoration: InputDecoration(
                      labelText: 'Description',
                      hintText: 'Enter a tidescriptiontle',
                      prefixIcon: Icon(Icons.text_fields),
                      errorText: formAWStore.error.description))),
          Observer(
              builder: (_) => TextField(
                  onChanged: (value) {
                    formAWStore.content = value;
                    formAWStore.validateContent();
                  },
                  maxLines: 5,
                  decoration: InputDecoration(
                      labelText: 'Content',
                      hintText: 'Enter a content',
                      prefixIcon: Icon(Icons.text_fields),
                      errorText: formAWStore.error.content))),
          TagInputChips(),
          RaisedButton(
              onPressed: () async {
                var validate = await formAWStore.validateAllFields();
                if (validate) {
                  await formAWStore.createArticle();
                  if (formAWStore.createArticleError) {
                    return Snackbar.createError(
                        message: "Some fields aren't conform !");
                  // } else if (formAWStore.createArticlePending) {
                  //   return Center(child: CircularProgressIndicator());
                  } else if (formAWStore.createArticleSuccessful) {
                    formAWStore.resetAllFields();
                    return Snackbar.createConfirmation(
                        message: "Article has been successfully created");
                  }
                } else {
                  return Snackbar.createError(
                      message: "Some fields aren't conform !");
                }
              },
              child: const Text('SUBMIT'))
        ],
      ),
    );
  }
}
