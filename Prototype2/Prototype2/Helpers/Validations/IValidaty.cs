using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype2.Helpers.Validations
{
    public interface IValidaty
    {
        bool IsValid { get; set; }
        bool IsButtonActive { get; set; }
    }
}
