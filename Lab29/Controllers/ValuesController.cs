using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lab29.Models;

namespace Lab29.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        public List<MoviesA> GetMovieList()
        {
            MoviesEntities1 DB = new MoviesEntities1();
            List<MoviesA> Movie = DB.MoviesAs.ToList();

            return Movie;
        }
        public List<MoviesA> GetMovieByCategory(string cat)
        {
            MoviesEntities1 DB = new MoviesEntities1();
            List<MoviesA> MovieCat = (from M in DB.MoviesAs
                                      where M.Category.Contains(cat)
                                      select M).ToList();

            return MovieCat;
        }
        
        public List<MoviesA> GetRandom()
        {
            Random rnd = new Random();
            MoviesEntities1 DB = new MoviesEntities1();
            List<MoviesA> MovieRnd = DB.MoviesAs.ToList();
            int MovieA = MovieRnd.Count() + 1;
            int MovieRnds = rnd.Next(0, MovieA);
            return MovieRnd;
        }
        public List<MoviesA> GetRandomByCat(string cat)
        {
            Random rnd = new Random();
            MoviesEntities1 DB = new MoviesEntities1();
            List<MoviesA> MovieCatR = (from M in DB.MoviesAs
                                      where M.Category.Contains(cat)
                                      select M).ToList();
            int MovieA = MovieCatR.Count() + 1;
            int MovieRnds = rnd.Next(0, MovieA);
            return MovieCatR;
        }
    }

    
}
