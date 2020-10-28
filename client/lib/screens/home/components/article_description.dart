import 'package:client/datas/models/article.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class ArticleDescription extends StatelessWidget {
  ArticleDescription({Key key, this.article}) : super(key: key);

  final Article article;

  @override
  Widget build(BuildContext context) {
    String dateToDisplay = '';
    if(article.createdAt.isAtSameMomentAs(article.updatedAt)) {
      var dateFormat = DateFormat('dd-MM-yyyy').format(article.createdAt);
      dateToDisplay = 'Publié le $dateFormat';
    } else {
      var dateFormat = DateFormat('dd-MM-yyyy').format(article.updatedAt);
      dateToDisplay = 'Mise à jour le $dateFormat';
    }
    return Container(
        child: Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: <Widget>[
        Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: <Widget>[
            Text(dateToDisplay,
                style: const TextStyle(
                    fontSize: 12.0,
                    fontWeight: FontWeight.bold,
                    color: Colors.grey)),
            SizedBox(height: 5.0),
            InkWell(
                onTap: () => Navigator.of(context)
                    .pushNamed('/articleDetails/${article.id}'),
                child: Text(
                  article.title,
                  maxLines: 2,
                  overflow: TextOverflow.ellipsis,
                  style: const TextStyle(
                    fontSize: 24.0,
                    fontWeight: FontWeight.bold,
                  ),
                )),
            const Padding(padding: EdgeInsets.only(bottom: 5.0)),
            Text(
              article.description,
              maxLines: 2,
              overflow: TextOverflow.ellipsis,
              style: const TextStyle(
                fontSize: 14.0,
              ),
            ),
            const Padding(padding: EdgeInsets.only(bottom: 5.0)),
          ],
        ),
        Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          mainAxisAlignment: MainAxisAlignment.end,
          children: <Widget>[
            SizedBox(
                height: 50,
                child: ListView.builder(
                  scrollDirection: Axis.horizontal,
                  shrinkWrap: true,
                  itemBuilder: (BuildContext context, int index) {
                    return Padding(padding: EdgeInsets.symmetric(horizontal: 5.0), child: Chip(label: Text(article.tags[index].name)));
                  },
                  itemCount: article.tags.length,
                ))
          ],
        ),
      ],
    ));
  }
}
