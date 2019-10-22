using Asp.NetWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Asp.NetWebApi.Controllers
{
    public class PersonelController : ApiController
    {
        private List<Personel> ListPersoneller = new List<Personel>
        {
            new Personel{Id=1,Ad="Feriha",Soyad="Kaya"},
            new Personel{Id=2,Ad="Kenan",Soyad="Deniz"},
            new Personel{Id=3,Ad="Feyzullah",Soyad="Derya"}

        };
        public IEnumerable<Personel> GetPersoneller()
        {
            return ListPersoneller ;
        }
        public IHttpActionResult GetPersonel(int id)
        {
            var arananPersonel = (from p in ListPersoneller
                                  where p.Id == id
                                  select p).FirstOrDefault();

            return Ok(arananPersonel);
        }

        public IHttpActionResult PostPersonel(Personel per)
        {
            if(ListPersoneller.Where(p=>p.Id == per.Id).Count()==0)
            {
                return Ok();
            }
            else
            {
                //ver varsa eklemez
                return Conflict();
            }
        }
    }
}
