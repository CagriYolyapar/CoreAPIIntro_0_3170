using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPIIntro_0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        static List<string> sehirler = new List<string>
        {
            "Istanbul","İzmir","Eskişehir","Ankara"
        };

        //HTTPStatusCodes
        //100 ile baslayan kodlar  => Information (Bilgilendirme)
        //200 ile baslayan kodlar => Success(Basarılı)
        //300 ile baslayan kodlar => Redirection (Yeniden yönlendirme)
        //400 ile baslayan kodlar => Client Errors (İstemci hataları)
        //500 ile baslayan kodlar => Server Errors (Sunucu hataları)


        //Get => Kullanıcının yeni bir istegi (Request,  mevcut durumda alınan bir response  varsa ondan bagımsız bir şeiklde taze bir haldedir)

        //Post => Gelen Response'un tekrar server'a geri gönderilmesidir...API'da sadece Creation islemleri icin kullanılması saglıklı olan HTTP request tipidir...

        //Put => API'da Update işlemleri icin kullanacagımız HTTP request tipidir...

        //Delete => API'da Delete islemleri icin kullanacagımız HTTP request tipidir...

        //MVC'de bir action'in basına Request tipi yazılmadıgında otomatik olarak o action Get tipinde algılanır...Lakin API'da durum böyle degildir...API'da Request tipi belirtilmeyen bir Action direkt hata verecektir...Dolayısıyla API'daki Controller icerisindekia Action'ların request tiplerinin belirtilmesi gerekir...

        [HttpGet]
        public IActionResult GetCityInfo()
        {
            return Ok(sehirler);
        }

        [HttpGet("Indexer")]
        public IActionResult GetCity(int id)
        {
            return Ok(sehirler[id]);
        }

        [HttpPost]
        public IActionResult AddCity(string item)
        {
            sehirler.Add(item);
            return Ok(sehirler);
        }

        [HttpDelete]
        public IActionResult DeleteCity(int id)
        {
            sehirler.Remove(sehirler[id]);
            return Ok(sehirler);    
        }

        [HttpPut]
        public IActionResult UpdateCity(int id,string newValue)
        {
            sehirler[id] = newValue;
            return Ok(sehirler);
        }
      
    }
}
