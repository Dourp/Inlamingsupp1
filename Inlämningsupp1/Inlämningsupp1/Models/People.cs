using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inlämningsupp1.Models
{
    public class People
    {
        public int PeopleId { get; set; }
        public string Namn { get; set; }
        public string Gatuadress { get; set; }
        public string Postnummer { get; set; }
        public string Postort { get; set; }
        public string Telefon { get; set; }
        public string Epost { get; set; }

        [Column(TypeName = "date")]
        public DateTime Födelsedag { get; set; }
    }
}
