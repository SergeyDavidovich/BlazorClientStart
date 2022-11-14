using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClientStart.Domain.Shared.Option
{
    internal class EmptyOptionNameException : Exception
    {
        public EmptyOptionNameException(string message)
            : base(message) { }
    }
}
