using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UserServices.Model
{
    public class User
    { 
        [Key]
        public int Id { get; set; }

        public int Age { get; set; }
        public string Name { set; get; }
        public string Email { set; get; }
    }
}
