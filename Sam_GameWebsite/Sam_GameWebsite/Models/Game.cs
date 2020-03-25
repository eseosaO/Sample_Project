using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam_GameWebsite.Models
{
    public class Game
    {
        public virtual int GameId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual string GameName { get; set; }
        public virtual string GameDescription { get; set; }
        public virtual Genre genre { get; set; }
        public virtual decimal Price { get; set; }
    }
}