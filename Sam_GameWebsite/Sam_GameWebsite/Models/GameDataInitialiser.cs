using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Sam_GameWebsite.Models
{
    public class GameDataInitialiser : DropCreateDatabaseAlways<GameContext>
    {
        protected override void Seed(GameContext context)
        {
            Genre gen1 = new Genre();
            gen1.GenreId = 1;
            gen1.GenreName = "Sport";
            gen1.GenreDescription = "Genre for adventure";
            context.Genres.Add(gen1);

            Genre gen2 = new Genre();
            gen2.GenreId = 2;
            gen2.GenreName = "Action";
            gen2.GenreDescription = "Genre for action games that involves shooting and fighting";
            context.Genres.Add(gen2);

            Game game1 = new Game();
            game1.GameId = 1;
            game1.GenreId = 1;
            game1.GameName = "FIFA20";
            game1.GameDescription = "Football game with real-life characters";
            game1.genre = gen1;
            context.Games.Add(game1);

            base.Seed(context);

        }
    }
}