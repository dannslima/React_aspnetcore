using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAtividade.API.Models;

namespace ProAtividade.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtividadeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Atividade> Get()
        {
            return new List<Atividade>(){
                new Atividade(1),
                new Atividade(2),
                new Atividade(3),

            };
        }

         [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"meu primeimro métoo get com parametro {id}";
        }

        [HttpPost ("{id}")]
        public string Post()
        {
            return "meu primeimro métoo post";
        }
        [HttpPut ("{id}")]
        public string Put()
        {
            return "meu primeimro métoo put";
        }
        [HttpDelete ("{id}")]
        public string Delete()
        {
            return "meu primeimro métoo delete";
        }
    }
}