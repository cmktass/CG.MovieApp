using CG.MovieAppEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CG.MovieApp.DataAccess.Concrate.EntityFrameworkCore.DatabaseFluentApi
{
    public class FilmCategoryConfiguration : IEntityTypeConfiguration<FilmCategory>
    {
        public void Configure(EntityTypeBuilder<FilmCategory> builder)
        {
            builder.HasKey(i => new { i.FilmId, i.CategoryId });
        }
    }
}
