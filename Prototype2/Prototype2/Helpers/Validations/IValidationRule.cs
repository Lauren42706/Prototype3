﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype2.Helpers.Validations
{
    public interface IValidationRule<T>
    {
        string ValidationMessage { get; set; }

        bool Check(T value);
    }
}
