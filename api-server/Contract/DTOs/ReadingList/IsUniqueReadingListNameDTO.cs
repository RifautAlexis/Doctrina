namespace api_server.Contract.DTOs
{
    public class IsUniqueReadingListNameDTO
    {
        public string Name { get; set; }
        public int? ReadingListId { get; set; }

        internal void Deconstruct(out string name, out int? readingListId)
        {
            name = Name;
            readingListId = ReadingListId;
        }
    }
}
