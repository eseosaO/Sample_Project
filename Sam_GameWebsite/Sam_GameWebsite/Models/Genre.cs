using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam_GameWebsite.Models
{
    public class Genre
    {
        public virtual int GenreId { get; set; }
        public virtual string GenreName { get; set; }
        public virtual string GenreDescription { get; set; }
    }
}