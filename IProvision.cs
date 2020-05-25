using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProvision
{
    public delegate void CookingHint(string message);
    public interface IProvision
    {
        public event CookingHint Info;
        public event CookingHint Error;

    }
}
