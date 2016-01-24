using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sandbox461.Data
{
    public class Sandbox461DbContext : DbContext
    {
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmMaker> FilmMakers { get; set; }

        public virtual DbSet<MailMessage> MailMessages { get; set; }
        public virtual DbSet<MailAddress> MailAddresses { get; set; }

    }
}