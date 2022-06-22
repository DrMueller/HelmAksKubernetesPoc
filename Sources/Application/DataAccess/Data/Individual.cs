using System;
using WebApplication1.DataAccess.Data.Base;

namespace WebApplication1.DataAccess.Data
{
    public class Individual : Entity
    {
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
