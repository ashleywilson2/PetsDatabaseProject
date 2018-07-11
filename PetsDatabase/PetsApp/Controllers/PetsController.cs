using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetsDatabase;
using PetsApp;

namespace PetsApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Pets")]
    public class PetsController : Controller
    {
        private readonly IDatabase database;
        public PetsController(IDatabase database)
        {
            this.database = database;
        }

        [HttpGet("{id}")] //read one pet
        public Pet Get(int id)
        {
            var pet = database.Read(id);
            return pet;
        }

        [HttpGet]  //read-all pets
        public Pet[] Get()
        {
            var pets = database.Readall();
            return pets.ToArray();
        }

        [HttpPost] //create 
        public void Post([FromBody]Pet pet)
        {
            database.Create(pet);
        }

        [HttpPost("{id}")]
        public void Post(int id, [FromBody]Pet pet)
        {
            pet.PetId = id;
            database.Update(pet);
        }

        [HttpDelete("{id}")]  //delete
        public void Delete(int id)
        {
            database.Delete(id);
        }

    }
}