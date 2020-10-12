using JobPoratal_MVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobPoratal_MVC.Repositories
{
    public interface IUserRepository:IDisposable
    {
        IEnumerable<UserDetails> userDetails();
        UserDetails GetUserById(int? id);
        void Create(UserDetails userDetails);
        void Edit(UserDetails userDetails,int? id);
    }
}