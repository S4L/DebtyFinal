using DebtyFinal.DataAccess.Queries;
using DebtyFinal.Interfaces;
using DebtyFinal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DebtyFinal.Logics
{
    public class PersonLogic : IPerson
    {
        private PersonQueries personQueries;

        public PersonQueries PersonQueries {
            get {
                if(personQueries == null)
                {
                    personQueries = new PersonQueries();
                }
                return personQueries;
            }
        }

        public string GetPersonIDByUserName(string userName)
        {
            return PersonQueries.GetPersonIDByUserName(userName);
        }
    }
}
