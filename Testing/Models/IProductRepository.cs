﻿using System;
using System.Collections.Generic;

namespace Testing
{
    public interface IProductRepository
    {

        public IEnumerable<Product> GetAllProducts();
    }
}
