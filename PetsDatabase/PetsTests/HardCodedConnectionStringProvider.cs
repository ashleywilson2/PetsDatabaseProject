﻿using System;
using System.Collections.Generic;
using System.Text;
using PetsDatabase;

namespace PetsTests
{
    public class HardCodedConnectionStringProvider : IConnectionStringProvider
    {
        public string GetConnectionString()
        {
            return @"Server=.\S2017E;Database=Pets;Trusted_Connection=true;";
        }
    }
}
