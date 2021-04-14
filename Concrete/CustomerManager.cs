using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfCustomerIsReal(customer))
            {
                Console.WriteLine("User is added to database! | Customer's Name: {0} {1}", customer.FirstName, customer.LastName);
            }
            else
            {
                Console.WriteLine("User couldn't be added to database! | Customer's Name: {0} {1}", customer.FirstName, customer.LastName);
            }
        }
        
        public void Update(Customer customer)
        {
            Console.WriteLine("User {0} {1}'s information has been updated.", customer.FirstName, customer.LastName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("User {0} {1}'s information has been deleted.", customer.FirstName, customer.LastName);
        }

        
    }
}
