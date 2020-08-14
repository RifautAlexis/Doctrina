using System.Collections.Generic;

namespace api_server.Data.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }

        /*****/

        public virtual ICollection<TagsAttributed> TagsAttributed { get; set; }
    }
}
