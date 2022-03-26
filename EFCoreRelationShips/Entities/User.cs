using EFCoreRelationShips.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreRelationShips.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        // single user can have multiple characters 1:n
        public List<Character> Characters { get; set; }
    }
}
