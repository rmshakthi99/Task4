using Microsoft.Extensions.Logging;
using ProfileMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileMVCProject.Services
{
    public class ProfileManager:IRepo<Profile>
    {
        private ProfileContext _context;
        private ILogger<ProfileManager> _logger;
        public ProfileManager(ProfileContext context, ILogger<ProfileManager> logger)
        {
            _context = context;
            _logger = logger;

        }
        public void Add(Profile t)
        {
            try
            {
                _context.Profile.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
        }
        public void Update(int id, Profile t)
        {
            Profile profile = Get(id);
            if (profile != null)
            {
                profile.PersonId = t.PersonId;
                profile.Name = t.Name;
                profile.age = t.age;
                profile.qualification = t.qualification;
                profile.IsEmployed = t.IsEmployed;
                profile.NoticePeriod = t.NoticePeriod;
                profile.CurrentCTC = t.CurrentCTC;
               

            }
            _context.SaveChanges();
        }
        public void Delete(Profile t)
        {
            try
            {
                _context.Profile.Remove(t);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
        }
        public Profile Get(int id)
        {
            try
            {
                Profile author = _context.Profile.FirstOrDefault(Profile => Profile.PersonId == id);
                return author;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }
        public IEnumerable<Profile> GetAll()
        {
            try
            {
                if (_context.Profile.Count() == 0)
                    return null;
                return _context.Profile;

                    

            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);

            }
            return null;
        }
    }
}
