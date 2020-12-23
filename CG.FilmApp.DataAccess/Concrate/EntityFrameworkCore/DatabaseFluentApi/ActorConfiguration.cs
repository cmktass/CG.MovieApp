using CG.MovieAppEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CG.MovieApp.DataAccess.Concrate.EntityFrameworkCore.DatabaseFluentApi
{
    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name).IsRequired().HasMaxLength(35);

            builder.Property(i => i.LastName).IsRequired().HasMaxLength(35);

            builder.Property(i => i.Country).IsRequired();

            builder.Property(i => i.BirthDate).IsRequired();
        }
    }
}
