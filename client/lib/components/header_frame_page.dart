import 'package:flutter/material.dart';

class HeaderFramePage extends StatelessWidget implements PreferredSizeWidget {
  const HeaderFramePage({
    Key key,
  }) : super(key: key);

  @override
  Size get preferredSize => Size.fromHeight(50.0);

  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisSize: MainAxisSize.max,
      children: [
        Expanded(
          child: Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [Text("LEFT")],
          )
        ),
        Expanded(
          child: Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [Text("MIDDLE")],
          )
        ),
        Expanded(
          child: Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [Text("RIGHT")],
          )
        ),
      ],
    );
  }
}
