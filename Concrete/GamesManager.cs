using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamesManager : IGamesService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Studio: {0}, Game: {1}, Price: {2}$ has been added to system.", game.Studio, game.Name, game.Price);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Studio: {0}, Game: {1} has been deleted from system.", game.Studio, game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Studio: {0}, Game: {1} has been updated.", game.Studio, game.Name);
        }
    }
}
