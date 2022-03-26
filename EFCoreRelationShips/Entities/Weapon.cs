using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCoreRelationShips.Entities
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; } = 10;
        // single character can only have single weapon 1:1
        [JsonIgnore]
        public Character Character { get; set; }
        public int CharacterId { get; set; }
    }
}
