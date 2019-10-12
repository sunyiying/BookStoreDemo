using System.ComponentModel.DataAnnotations;

namespace Jerry.BookStore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}