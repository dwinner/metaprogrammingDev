﻿using System;

namespace Customers.Lib
{
   public interface ICustomer
   {
      int Age { get; set; }
      Guid Id { get; set; }
      string FirstName { get; set; }
      string LastName { get; set; }
   }
}