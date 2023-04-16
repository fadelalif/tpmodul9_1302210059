using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using tpmodul9_1302210059;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302213102.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> ListMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Fadel Alif Sadena", "1302210059"),
            new Mahasiswa("Fahryan Anggriantaka", "1302213102"),
            new Mahasiswa("Muhammad Nagif", "1302210130"),
            new Mahasiswa("Muhammad Nurrasyid", "1302213039"),
            new Mahasiswa("Muhammad Ryan Piskadinata", "1302210124")
        };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return ListMahasiswa;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return ListMahasiswa[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            ListMahasiswa.Add(value);
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ListMahasiswa.RemoveAt(id);
        }
    }
}