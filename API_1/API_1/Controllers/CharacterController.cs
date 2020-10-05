using API_1.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController:ControllerBase
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character{Name="Sanjsi"}
        };

        public  IActionResult Get()
        {
            return Ok(characters);
        }
    }
}
