﻿using EFCoreRelationShips.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRelationShips.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // will register all the entities here

        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Skill> Skills { get; set; }

        // will register all the entities here
    }
}
