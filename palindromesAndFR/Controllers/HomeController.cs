using Microsoft.AspNetCore.Mvc;
using PalinAndFR.Models;
using System.Collections.Generic;
using System;

namespace PalinAndFR.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }
        [HttpPost("/")]
        public ActionResult IndexPost()
        {
            string function = Request.Form["function"];
            string inputPalindrome = Request.Form["palindromeinputString"];
            string inputFR = Request.Form["inputFR"];
            string find = Request.Form["findFR"];
            string replace = Request.Form["replaceFR"];
            string rpsPlayerOne = Request.Form["rpsPlayerOne"];
            string rpsPlayerTwo = Request.Form["rpsPlayerTwo"];
            string anagramField = Request.Form["anagram"];
            string inputScrabble =Request.Form["scrabble"];
            if(function == "palindromes")
            {
                Palindrome newModel = new Palindrome(inputPalindrome);
                return View("Index", newModel);

            } else if(function == "fr")
            {
                FindAndReplace newModel = new FindAndReplace(inputFR, find, replace);
                // Console.WriteLine("RPSAI");
                return View("Index", newModel);
            } else if(function == "rpsai")
            {
                RockPaperScissors newModel = new RockPaperScissors(rpsPlayerOne , "");
                newModel.AIPlay();
                // Console.WriteLine("RPS");
                return View("Index", newModel);
            } else if(function == "rps")
            {
                RockPaperScissors newModel = new RockPaperScissors(rpsPlayerOne, rpsPlayerTwo);
                // Console.WriteLine("Palindrome");
                return View("Index", newModel);
            } else if(function == "anagram")
            {
                Anagram newModel = new Anagram(anagramField);
                // Console.WriteLine("Anagram");
                return View("Index", newModel);
            } else if(function == "scrabble")
            {
                Scrabble newModel = new Scrabble(inputScrabble);
                // Console.WriteLine("Scrabble");
                return View("Index", newModel);
            } else {

            }
            return View("Index");
        }
    }
}
