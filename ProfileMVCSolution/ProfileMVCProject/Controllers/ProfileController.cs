using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProfileMVCProject.Models;
using ProfileMVCProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProfileMVCProject.Controllers;

namespace ProfileMVCProject.Controllers
{
    public class ProfileController : Controller
    {
        
        private ILogger<ProfileController> _logger;
        private IRepo<Profile> _repo;
        public ProfileController(IRepo<Profile> repo, ILogger<ProfileController> logger)
        {
            _logger = logger;
            _repo = repo;
        }


        public IActionResult Index()
        {
            List<Profile> profiles = _repo.GetAll().ToList();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Profile profiles)
        {
            try
            {
                _repo.Add(profiles);
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View();
            }
            
        }
        public IActionResult Edit(int id)
        {
            try
            {
                Profile profiles = _repo.Get(id);
                return View(profiles);

            }
            catch(Exception e)
            {
                return View();
                Console.WriteLine(e.Message);
            }
            
        }
        [HttpPost]
        public IActionResult Edit(int id, Profile profiles)
        {
            try
            {
                _repo.Update(id, profiles);
                return RedirectToAction("Index");

            }
            catch(Exception e)
            {
                return View();
                Console.WriteLine(e.Message);
            }
            
        }
        public IActionResult Delete(int id)
        {
            Profile personsprofile = _repo.Get(id);
            return View(personsprofile);

        }
        [HttpPost]
        public IActionResult Delete(Profile personsprofile)
        {
            try
            {
                _repo.Delete(personsprofile);
                return RedirectToAction("Index");

            }
            catch(Exception e)
            {
                return View();
                Console.WriteLine(e.Message);
            }


        }

    }
}
   
