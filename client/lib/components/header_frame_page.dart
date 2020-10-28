import 'package:client/components/clickable_icon.dart';
import 'package:client/components/clickable_text.dart';
import 'package:client/mobx/authentication_store.dart';
import 'package:flutter/material.dart';

import 'package:font_awesome_flutter/font_awesome_flutter.dart';
import 'package:provider/provider.dart';

class HeaderFramePage extends StatelessWidget implements PreferredSizeWidget {
  const HeaderFramePage({
    Key key,
  }) : super(key: key);

  @override
  Size get preferredSize => Size.fromHeight(150.0);

  @override
  Widget build(BuildContext context) {
    final authStore = Provider.of<AuthenticationStore>(context);
    return Container(
      color: Colors.blue,
      child: Row(
        mainAxisSize: MainAxisSize.max,
        children: [
          Expanded(
            child: Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                ClickableText(
                  text: 'Home',
                  action: () => Navigator.pushNamed(context, '/'),
                  margin: EdgeInsets.only(left: 25.0),
                ),
                VerticalDivider(
                  thickness: 1.0,
                ),
                ClickableText(
                  text: 'About',
                  action: () => Navigator.pushNamed(context, '/about'),
                  margin: EdgeInsets.only(left: 25.0),
                ),
                VerticalDivider(
                  thickness: 1.0,
                ),
                ClickableText(
                  text: "Knowledge Coffee",
                  action: () =>
                      Navigator.pushNamed(context, '/knowledge-coffee'),
                  margin: EdgeInsets.only(left: 25.0),
                ),
              ],
            ),
          ),
          Expanded(
            child: Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                authStore.hasCurrentUser
                    ? ClickableText(
                        text: "Logout",
                        action: () => authStore.logout(),
                        margin: EdgeInsets.only(left: 25.0),
                      )
                    : Container(),
                ClickableIcon(
                  icon: Icon(
                    FontAwesomeIcons.linkedin,
                    color: Colors.white,
                    size: 24.0,
                    semanticLabel: 'Linkdein',
                  ),
                  destinationToGo: 'https://www.linkedin.com/in/rifaut-alexis/',
                  margin: EdgeInsets.only(left: 25.0),
                ),
                ClickableIcon(
                  icon: Icon(
                    FontAwesomeIcons.github,
                    color: Colors.white,
                    size: 24.0,
                    semanticLabel: 'Github',
                  ),
                  destinationToGo: 'https://github.com/RifautAlexis',
                  margin: EdgeInsets.only(left: 25.0),
                ),
              ],
            ),
          ),
        ],
      ),
    );
  }
}
