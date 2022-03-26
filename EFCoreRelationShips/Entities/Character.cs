using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EFCoreRelationShips.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RPGClass { get; set; } = "Knight";
        // multiple character can be obtaied by a single user n:1
        [JsonIgnore]
        public User User { get; set; }
        public int UserId { get; set; }
        // single character can only have single weapon 1:1
        public Weapon Weapon { get; set; }
        // multiple characters can have multiple skills
        public List<Skill> Skills { get; set; }
    }
}
