import 'package:flutter/material.dart';
import 'dart:html' as html;

class ClickableIcon extends StatelessWidget {
  const ClickableIcon(
      {Key key,
      @required this.icon,
      @required this.destinationToGo,
      this.margin})
      : super(key: key);

  final Icon icon;
  final String destinationToGo;
  final EdgeInsetsGeometry margin;

  @override
  Widget build(BuildContext context) {
    return Container(
      margin: margin,
      child: InkWell(
        child: icon,
        onTap: () => html.window.location.href = destinationToGo,
      ),
    );
  }
}
