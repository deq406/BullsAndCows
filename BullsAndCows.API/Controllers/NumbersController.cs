using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BullsAndCows.Service;
using BullsAndCows.Database;

using BullsAndCows.Service.Models;

namespace BullsAndCows.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {

        private readonly GameService _gameService;
        private readonly ILogger<NumbersController> _logger;
        public NumbersController(ILogger<NumbersController> logger, GameService gameService)
        {
            _logger = logger;
            _gameService = gameService ?? throw new ArgumentNullException();
        }

        [HttpGet]
        public Game CreateGame()
        {
            return _gameService.CreateGame();

        }

        [HttpPut("{id}/{number}")]
        public CowsAndBullsModel CheckNumber(int id, int number)
        {
            //Int32.TryParse(number, out var numberInt);
            
            return _gameService.CheckNumber(id, number);
        }

        //// GET: api/Numbers/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(string id)
        //{
        //    var number = new Numbers();
        //    number.NovoeChislo();
        //    number.s.ToString();
        //    while (number.polnoeSovpadenie != 4)
        //    {
        //        if (id.Length != 4)
        //        {

        //            return "Введите четырехзначное число";
        //        }
        //        else
        //        {
        //            number.SravenieChisel(id);
        //            if (number.polnoeSovpadenie == 4)
        //            {
        //                return ("Вы угадали правильное число");
        //                //using (PlayerContext db = new PlayerContext())
        //                //{
        //                //    var result = db.Players.Where(s => s.login == userName && s.password == userPass).ToList();
        //                //    for (int i = 0; i < result.Count; i++)
        //                //    {
        //                //        result[i].numberOfGames++;
        //                //        db.SaveChanges();
        //                //    }
        //                //}
        //            }
        //            else
        //            {
        //                return ("Полностью совпало " + number.polnoeSovpadenie + " совпало " + number.chastichnoeSovpadenie);
        //            }  
        //        }

        //    }
        //    return "1";
        //}

        // POST: api/Numbers
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //PUT: api/Numbers/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{

        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
