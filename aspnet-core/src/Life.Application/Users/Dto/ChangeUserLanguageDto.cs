using System.ComponentModel.DataAnnotations;

namespace Life.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}