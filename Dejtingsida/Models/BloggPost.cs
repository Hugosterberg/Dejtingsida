using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace Dejtingsida.Models
{
        public class Inlägg
        {
            [Key]
            public int Post_Id { get; set; }
            public string Avsändare { get; set; }
            public string Mottagare { get; set; }

            public DateTimeOffset SkickatDatum { get; set; }
            public string MeddelandeText { get; set; }
        }
    }

