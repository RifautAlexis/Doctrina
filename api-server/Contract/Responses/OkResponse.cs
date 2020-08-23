namespace api_server.Contract.Responses
{
    public class OkResponse : Response
    {
        public OkResponse(object result) : base(200, result) { }
    }
}
