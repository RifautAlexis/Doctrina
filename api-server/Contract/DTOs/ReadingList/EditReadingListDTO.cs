﻿namespace api_server.Contract.DTOs
{
    public class EditReadingListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        internal void Deconstruct(out int id, out string name)
        {
            id = Id;
            name = Name;
        }
    }
}
