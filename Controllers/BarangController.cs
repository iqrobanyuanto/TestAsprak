using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAsprak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarangController : ControllerBase
    {
 
        [HttpGet]
        public IEnumerable<Barang> Get()
        {
            JsonLibrary.check();
            List<Barang> barangList = JsonLibrary.deserialize();
            return barangList;
        }
        [HttpPost]
        public void Post([FromBody] Barang barang)
        {
            List<Barang> barangList = JsonLibrary.deserialize();
            barangList.Add(barang);
            JsonLibrary.serialize(barangList);

        }
        [HttpPut("{nama}")]
        public void Put(string nama, Barang barang)
        {
            List<Barang> barangList = JsonLibrary.deserialize();
            foreach (Barang bar in barangList)
            {
                if(bar.nama == nama)
                {
                    bar.rating = barang.rating;
                }
            }
            JsonLibrary.serialize(barangList);
        }
        [HttpDelete("{nama}")]
        public void Delete(string nama)
        {
            List<Barang> barangList = JsonLibrary.deserialize();
            foreach (Barang bar in barangList)
            {
                if (bar.nama == nama)
                {
                    barangList.Remove(bar);
                }
            }
            JsonLibrary.serialize(barangList);
        }
    }
}
