﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnigramsProductionsV2.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AnigramsEntities : DbContext
    {
        public AnigramsEntities()
            : base("name=AnigramsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GenLanguage> GenLanguages { get; set; }
        public virtual DbSet<GenLanguageSymbol> GenLanguageSymbols { get; set; }
        public virtual DbSet<GenSuffix> GenSuffixes { get; set; }
        public virtual DbSet<GenSymbol> GenSymbols { get; set; }
        public virtual DbSet<AnigramsCharacter> AnigramsCharacters { get; set; }
        public virtual DbSet<AnigramsProject> AnigramsProjects { get; set; }
        public virtual DbSet<AnigramsReview> AnigramsReviews { get; set; }
    }
}
