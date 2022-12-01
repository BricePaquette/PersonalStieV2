using System.ComponentModel.DataAnnotations;

namespace PersonalSiteV2.UI.MVC.Models
{
    public class ContactViewModel
    {
        //We can use Data Annotations to add Validation to our model.
        //This is useful when we have required fields or need certain types of info.


        [Required(ErrorMessage = "*Name is required")]
        [DataType(DataType.Text)]
        public string Name { get; set; } //must be alphabetic characters

        [Required(ErrorMessage = "*Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } //Must contain an @ symbol and extention .com, .net, ect

        [Required(ErrorMessage = "*Subject is required")]
        public string Subject { get; set; } //Must contain text

        [Required(ErrorMessage = "*Message is required")]
        [DataType(DataType.MultilineText)]//Notes that the field should have a bigger text-box(text-area)
        public string Message { get; set; } //Must contain text

    }
}