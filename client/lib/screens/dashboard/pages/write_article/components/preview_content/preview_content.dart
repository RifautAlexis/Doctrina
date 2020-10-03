import 'package:flutter/material.dart';
import 'package:flutter_markdown/flutter_markdown.dart';

class PreviewContent extends StatelessWidget {
  final String content;

  const PreviewContent({Key key, @required this.content}) : super(key: key);

  // final String _markdownData = '## Code Inline `code` Indented code // Some comments line 1 of code line 2 of code line 3 of code Block code "fences" ``` Sample text here... ``` Syntax highlighting ``` js var foo = function (bar) { return bar++; }; console.log(foo(5)); ```';

  @override
  Widget build(BuildContext context) {
    print(content);
    return Markdown(data: content);
  }
}