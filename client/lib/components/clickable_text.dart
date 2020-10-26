import 'package:flutter/material.dart';

class ClickableText extends StatelessWidget {
  const ClickableText(
      {Key key,
      @required this.text,
      @required this.action,
      this.margin})
      : super(key: key);

  final String text;
  final Function action;
  final EdgeInsetsGeometry margin;

  @override
  Widget build(BuildContext context) {
    return Container(
      margin: margin,
      child: InkWell(
        child: Text(text),
        onTap: () {
          action();
        },
      ),
    );
  }
}
