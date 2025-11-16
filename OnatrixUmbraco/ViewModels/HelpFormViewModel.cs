using System.ComponentModel.DataAnnotations;

namespace OnatrixUmbraco.ViewModels;

public class HelpFormViewModel
{
    [Required(ErrorMessage = "Email is required")]
    [Display(Name = "E-mail address")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;


    //Tog hjälp utav ChatGPT med detta, för att det är i en blocklist så måste detta med.
    public Guid ContentUdi { get; set; }
    public int? Index { get; set; }
    public int? ParentId { get; set; }
}
