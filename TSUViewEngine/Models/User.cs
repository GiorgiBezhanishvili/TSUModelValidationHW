using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TSUViewEngine.Models
{
    public class User
    {
        public User()
        {

        }

        public User(int id,string name,string lastname,string email,string pass)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            Email = email;
            Password = pass;
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "ველი სავალდებულოა")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "ელ. ფოსტის მისამართი არ არის ვალიდური")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
