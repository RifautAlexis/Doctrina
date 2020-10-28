class BooleanResponse {
  final bool value;

  BooleanResponse({this.value});

  factory BooleanResponse.fromJson(Map<String, dynamic> response) {
    return BooleanResponse(
      value: response["value"] as bool,
    );
  }
}
