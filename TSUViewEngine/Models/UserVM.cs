using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TSUViewEngine.Models
{
    public class UserVM
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "ველი სავალდებულოა")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "ელ. ფოსტის მისამართი არ არის ვალიდური")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "პაროლი უნდა იყოს მინიმუმ {2} და მაქსიმუმ {1} სიმბოლოიანი.", MinimumLength = 10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "პაროლები ერთმანეთს არ ემთხვევა!")]
        public string PasswordConfirmation { get; set; }

    }
}
