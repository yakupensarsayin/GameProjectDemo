using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IGamesService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
