using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace wwlp.Domain.Entities
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public bool Active { get; set; }
        public DateTime? DataAdded { get; set; }
        public DateTime? DataChanged { get; set; }
    }
}
