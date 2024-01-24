using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAsprak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarangController : ControllerBase
    {
        /*
        [HttpGet]
        public IEnumerable<Barang> Get()
        {
            // return list barang
        }*/
        [HttpPost]
        public void Post([FromBody] Barang barang)
        {

        }
        [HttpPut("{nama}")]
        public void Put(string nama, Barang barang)
        {
            //update ke dalam list nya
        }
        [HttpDelete("{nama}")]
        public void Delete(string nama)
        {
            //hapus dari list nya
        }
    }
}
