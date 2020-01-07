using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dejtingsida.Models
{
    public class Profil
    {
        [Key]
        public string AnvändarID { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public DateTime Födelsedatum { get; set; }
        public string BildURL { get; set; }
        public string Bio { get; set; }
    }
}