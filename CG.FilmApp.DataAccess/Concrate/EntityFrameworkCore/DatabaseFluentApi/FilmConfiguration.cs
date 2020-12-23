using CG.MovieAppEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CG.MovieApp.DataAccess.Concrate.EntityFrameworkCore.DatabaseFluentApi
{
    public class FilmConfiguration : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.ImdbScore).IsRequired();

            builder.Property(i => i.NameEn).IsRequired().HasMaxLength(50);

            builder.Property(i => i.NameTr).IsRequired().HasMaxLength(50);

            builder.Property(i => i.Revenues).IsRequired();

            builder.Property(i => i.Time).IsRequired();

            builder.Property(i => i.Title).IsRequired().HasMaxLength(1500);

            builder.Property(i => i.VisionDate).IsRequired();

            builder.HasMany(i => i.FilmCategories).WithOne(i => i.Film).HasForeignKey(i => i.FilmId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
