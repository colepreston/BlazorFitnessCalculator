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

    public string Name { get; set; } = null!;
    public int? Age { get; set; } = null;
    public double? Height { get; set; } = null;
    public double? Weight { get; set; } = null;
    public int? Gender { get; set; } = null; // Can also be nullable if needed
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
