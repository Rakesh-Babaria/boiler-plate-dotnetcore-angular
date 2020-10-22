using System.ComponentModel.DataAnnotations;

namespace boiler-plate-core-angular.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}