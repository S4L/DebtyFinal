using DebtyFinal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DebtyFinal.Interfaces
{
    public interface IPerson
    {
        string GetPersonIDByUserName(string userName);
    }
}
