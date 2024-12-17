using System.ComponentModel.DataAnnotations;

public class UserDataService
{
    // Properties to hold user data
    /*
    public string Name { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public int Gender { get; set; }
    public double BMR { get; set; }
    */


    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a positive number")]
    public int? Age { get; set; } = null;
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a positive number")]
    public int? Height { get; set; } = null;
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a positive number")]
    public int? Weight { get; set; } = null;



    //public string Name { get; set; } = null!;
    //public int? Age { get; set; } = null;
    //public double? Height { get; set; } = null;
    //public double? Weight { get; set; } = null;
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a positive number")]
    public int? Gender { get; set; } = 10; // Can also be nullable if needed
    public double? BMR { get; set; } = null;

    // Optionally, you can add methods to perform operations on the data if needed
    public void ResetData()
    {
        Name = string.Empty;
        Age = null;
        Height = null;
        Weight = null;
        Gender = null;
        BMR = null;
    }
}
