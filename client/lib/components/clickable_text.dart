import 'package:flutter/material.dart';

class ClickableText extends StatelessWidget {
  const ClickableText(
      {Key key,
      @required this.text,
      @required this.destinationToGo,
      this.margin})
      : super(key: key);

  final String text;
  final String destinationToGo;
  final EdgeInsetsGeometry margin;

  @override
  Widget build(BuildContext context) {
    return Container(
      margin: margin,
      child: InkWell(
        child: Text(text),
        onTap: () {
          Navigator.pushNamed(context, destinationToGo);
        },
      ),
    );
  }
}
