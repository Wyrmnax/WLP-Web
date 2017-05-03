using System;

namespace wwlp.Domain.Entities
{
    public class User
    {
        public int ID { get; set; }
        public bool Active { get; set; }
        public DateTime? DataAdded { get; set; }
        public DateTime? DataChanged { get; set; }
    }
}
