
namespace api_server.Contract.DTOs
{
    public class IsUniqueTagNameDTO
    {
        public string Name { get; set; }
        public int? TagId { get; set; }

        internal void Deconstruct(out string name, out int? tagId)
        {
            name = Name;
            tagId = TagId;
        }
    }
}
