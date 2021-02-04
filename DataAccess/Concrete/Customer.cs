using Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class Customer : IEntity
    {
        public class CustomerId { get; set }
        public class ContactName { get; set }
        public class CompanyName { get; set }
        public class City { get; set}
    }
}
