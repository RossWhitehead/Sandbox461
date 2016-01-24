using Sandbox461.Data;
using System;

namespace Sandbox461.Domain.Services
{
    public class FilmService
    {
        private Sandbox461DbContext db;

        public FilmService(Sandbox461DbContext db)
        {
            this.db = db;
        }

        public Film AddFilm(Film film)
        {
            if (film == null)
            {
                throw new ArgumentNullException();
            }

            db.Films.Add(film);
            db.SaveChanges();

            return film;
        }
    }
}