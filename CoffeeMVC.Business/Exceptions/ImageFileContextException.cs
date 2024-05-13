﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMVC.Business.Exceptions
{
    public class ImageFileContextException : Exception
    {
        public ImageFileContextException(string? message) : base(message)
        {
        }
    }
}
