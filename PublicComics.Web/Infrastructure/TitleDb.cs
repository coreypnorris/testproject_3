using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PublicComics.Domain;

namespace PublicComics.Web.Infrastructure
{
    public class TitleDb :  DbContext, ITitleDataSource
    {
        public DbSet<Title> Titles { get; set; }

        IQueryable<Title> ITitleDataSource.Titles
        {
            get { return Titles; }
        }
    }
}