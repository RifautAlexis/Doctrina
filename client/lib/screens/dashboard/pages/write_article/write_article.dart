import 'package:client/blocs/forms/write_article_form_bloc.dart';
import 'package:client/screens/dashboard/pages/write_article/components/dashboard.dart';
import 'package:client/screens/dashboard/pages/write_article/components/form_write_article/form_write_article.dart';
import 'package:client/screens/dashboard/pages/write_article/components/preview_content/preview_content.dart';
import 'package:client/services/article_service.dart';
import 'package:flutter/material.dart';
import 'package:flutter_form_bloc/flutter_form_bloc.dart';
import 'package:flutter_markdown/flutter_markdown.dart';

class WriteArticle extends StatefulWidget {
  const WriteArticle({Key key}) : super(key: key);


  @override
  _WriteArticleState createState() => _WriteArticleState();
}

class _WriteArticleState extends State<WriteArticle> {

  WriteArticleFormBloc formBloc;

  @override
  void initState() {
    super.initState();
  }

  @override
  void dispose() {
    super.dispose();
    formBloc.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Dashboard(
      body: _buildPage(context),
    );
  }

  Widget _buildPage(BuildContext context) {
    return BlocProvider(
        create: (context) =>
            WriteArticleFormBloc(articleService: ArticleService()),
        child: Builder(builder: (context) {
          this.formBloc = BlocProvider.of<WriteArticleFormBloc>(context);

          return FormBlocListener<WriteArticleFormBloc, String, String>(
              onSubmitting: (context, state) {
                // LoadingDialog.show(context);
              },
              onSuccess: (context, state) {
                // LoadingDialog.hide(context);

                // Navigator.of(context).pushReplacement(
                //     MaterialPageRoute(builder: (_) => SuccessScreen()));
              },
              onFailure: (context, state) {
                // LoadingDialog.hide(context);

                // Scaffold.of(context).showSnackBar(
                //     SnackBar(content: Text(state.failureResponse)));
              },
              child: Column(children: [
                Text("value => " + formBloc.contentInput.value),
                Text("isEmpty => " + formBloc.contentInput.isEmpty.toString()),
                Text("state => " + formBloc.contentInput.state.value),
                FormWriteArticle(writeArticleFormBloc: formBloc),
                Divider(
                  thickness: 3.0,
                ),
                Expanded(
                    child: PreviewContent(content: formBloc.contentInput.value)
                  )
              ])
              );
        }));
  }
}

class LoadingDialog extends StatelessWidget {
  static void show(BuildContext context, {Key key}) => showDialog<void>(
        context: context,
        useRootNavigator: false,
        barrierDismissible: false,
        builder: (_) => LoadingDialog(key: key),
      ).then((_) => FocusScope.of(context).requestFocus(FocusNode()));

  static void hide(BuildContext context) => Navigator.pop(context);

  LoadingDialog({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return WillPopScope(
      onWillPop: () async => false,
      child: Center(
        child: Card(
          child: Container(
            width: 80,
            height: 80,
            padding: EdgeInsets.all(12.0),
            child: CircularProgressIndicator(),
          ),
        ),
      ),
    );
  }
}

class SuccessScreen extends StatelessWidget {
  SuccessScreen({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            Icon(Icons.tag_faces, size: 100),
            SizedBox(height: 10),
            Text(
              'Success',
              style: TextStyle(fontSize: 54, color: Colors.black),
              textAlign: TextAlign.center,
            ),
            SizedBox(height: 10),
            RaisedButton.icon(
              onPressed: () => Navigator.of(context).pushReplacement(
                  MaterialPageRoute(builder: (_) => WriteArticle())),
              icon: Icon(Icons.replay),
              label: Text('AGAIN'),
            ),
          ],
        ),
      ),
    );
  }
}
