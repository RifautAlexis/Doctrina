import 'package:client/components/clickable_icon.dart';
import 'package:client/components/clickable_text.dart';
import 'package:flutter/material.dart';

import 'package:font_awesome_flutter/font_awesome_flutter.dart';

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
            children: [
              ClickableText(
                text: 'Home',
                destinationToGo: '/',
                margin: EdgeInsets.only(left: 25.0),
              ),
              ClickableText(
                text: 'About',
                destinationToGo: '/about',
                margin: EdgeInsets.only(left: 25.0),
              ),
              ClickableText(
                text: "Knowledge Coffee",
                destinationToGo: '/knowledge-coffee',
                margin: EdgeInsets.only(left: 25.0),
              ),
            ],
          ),
        ),
        // Expanded(
        //   child: Row(
        //     mainAxisAlignment: MainAxisAlignment.center,
        //     children: [Text("MIDDLE")],
        //   )
        // ),
        Expanded(
          child: Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              ClickableIcon(
                  icon: Icon(
                    FontAwesomeIcons.linkedin,
                    color: Colors.white,
                    size: 24.0,
                    semanticLabel: 'Linkdein',
                  ),
                  destinationToGo:
                      'https://www.linkedin.com/in/rifaut-alexis/',
                margin: EdgeInsets.only(left: 25.0),),
              ClickableIcon(
                  icon: Icon(
                    FontAwesomeIcons.github,
                    color: Colors.white,
                    size: 24.0,
                    semanticLabel: 'Github',
                  ),
                  destinationToGo: 'https://github.com/RifautAlexis',
                margin: EdgeInsets.only(left: 25.0),),
            ],
          ),
        ),
      ],
    );
  }
}
