﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameGenie.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gamegenie_dbEntities : DbContext
    {
        public gamegenie_dbEntities()
            : base("name=gamegenie_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GuessNumber> GuessNumbers { get; set; }
        public virtual DbSet<MemoryGame> MemoryGames { get; set; }
        public virtual DbSet<Pacman> Pacmen { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<RockPaperScissor> RockPaperScissors { get; set; }
        public virtual DbSet<Tetri> Tetris { get; set; }
    }
}
