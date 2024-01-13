using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography.X509Certificates;

namespace ERP_APP.Data
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
