using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ISalesService
    {
        void Sell(Customer customer, Game game, Campaign campaign);
    }
}
