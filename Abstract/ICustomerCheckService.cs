using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfCustomerIsReal(Customer customer);
    }
}
