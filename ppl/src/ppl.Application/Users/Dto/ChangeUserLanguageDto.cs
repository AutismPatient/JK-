using System.ComponentModel.DataAnnotations;

namespace ppl.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}