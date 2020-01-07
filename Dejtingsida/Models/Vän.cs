using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dejtingsida.Models
{
    public class Vän
    {
        [Key]
        public int VänID { get; set; }
        public string Person1 { get; set; }
        public string Person2 { get; set; }
    }
}