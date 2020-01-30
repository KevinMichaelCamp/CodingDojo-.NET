using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ViewModels.Models;

namespace ViewModels.Collections
{
    public class ViewModelController : Controller
    {
        public List<User> GenerateUsers()
        {
            return new List<User>
            {
                new User(){ FirstName="Kevin", LastName="Camp"},
                new User(){ FirstName="John", LastName="Doe"},
                new User(){ FirstName="Bob", LastName="Vila"},
                new User(){ FirstName="Paul", LastName="Reubens"}
            };
        }


        [HttpGet("")]
        public ViewResult Index()
        {
            string message = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat iure pariatur obcaecati harum neque! Nihil assumenda cupiditate doloremque error delectus consequuntur culpa non fugiat debitis natus eos, voluptates quaerat magni.";
            return View("Index", message);
        }

        [HttpGet("numbers")]
        public ViewResult Numbers()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            return View(numbers);
        }

        [HttpGet("users")]
        public ViewResult Users()
        {
            var users = GenerateUsers();
            return View(users);
        }

        [HttpGet("user")]
        public ViewResult UserInfo()
        {
            var rand = new Random();
            var users = GenerateUsers();
            var user = users[rand.Next(users.Count)];
            return View(user);
        }
    }
}