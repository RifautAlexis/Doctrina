class IdResponse {
  final int id;

  IdResponse({this.id});

  factory IdResponse.fromJson(Map<String, dynamic> response) {
    return IdResponse(
      id: response["id"] as int,
    );
  }
}
