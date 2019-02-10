using DebtyFinal.Interfaces;
using DebtyFinal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebtyFinal.DataAccess.Queries
{
    public class PersonQueries : IPerson
    {
        public string GetPersonIDByUserName(string userName)
        {
            using(var context = new DebtyDBContext())
            {
                var userId = context.Persons.Single(p => p.UserName == userName).Id;
                return userId;
            }
        }
    }
}
