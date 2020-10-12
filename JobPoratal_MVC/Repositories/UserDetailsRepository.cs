using JobPoratal_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPoratal_MVC.Repositories
{
    public class UserDetailsRepository : IUserRepository
    {
        private ApplicationDbContext _dbContext = null;
        public UserDetailsRepository()
        {
            _dbContext = new ApplicationDbContext();
        }
        public void Create(UserDetails userDetails)
        {
            if (userDetails == null)
            {
                throw new ArgumentNullException(nameof(userDetails));
            }
            _dbContext.UserDetails.Add(userDetails);
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }

        public void Edit(UserDetails userDetails, int? id)
        {
            if(id==null || userDetails == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            var user = _dbContext.UserDetails.SingleOrDefault(user1 => user1.Id == id);
            user.FirstName = userDetails.FirstName;
            user.LastName = userDetails.LastName;
            user.DateOfBirth = userDetails.DateOfBirth;
            user.Address = userDetails.Address;
            user.AppliedDate = userDetails.AppliedDate;
            user.Email = userDetails.Email;
            user.Gender = userDetails.Gender;
            user.Qualification = userDetails.Qualification;
            user.Experience = userDetails.Experience;
            //user.UploadResume = userDetails.UploadResume;
            _dbContext.SaveChanges();
        }

        public UserDetails GetUserById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException(nameof(id));
            }
            var user = _dbContext.UserDetails.SingleOrDefault(user1 => user1.Id == id);
            return user;
        }

        public IEnumerable<UserDetails> userDetails()
        {
            var user = _dbContext.UserDetails.ToList();
            return user;
        }
    }
}