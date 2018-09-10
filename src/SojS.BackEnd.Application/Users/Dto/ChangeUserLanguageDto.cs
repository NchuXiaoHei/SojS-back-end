using System.ComponentModel.DataAnnotations;

namespace SojS.BackEnd.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}