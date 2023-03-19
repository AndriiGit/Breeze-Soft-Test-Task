using System.ComponentModel.DataAnnotations;

namespace Breeze_Soft_Test_Task.Domain;
public enum EngineType
{
    ELECTRIC,
    PETROL,
    DIESEL,
    HIBRID,
    LPG
}
public class Car
{
    public int Id { get; set; }

    [Required]
    public string Producer { get; set; }
    
    [Required]
    public string Name { get; set; }

    [Range(1, 1000)]
    [RegularExpression(@"^[0-9][0-9]{0,2}$|^[0-9][0-9]{0,2}(\.[0-9]{1,2})$", ErrorMessage = "Value must be decimal from 0.01 to 999.99")]
    public float EnginePower { get; set; }
    
    public EngineType Engine { get; set; }
    
    [RegularExpression(@"^[1][0-9]{0,1}|[2][0]{0,1}|[1-9]$", ErrorMessage = "Value must be integer from 1 to 20")]
    public byte? AmountOfCylinders { get; set; }
    
    [Required] 
    public string Color { get; set; }
    
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode=true)]
    public DateTime ProducedDate { get; set; }
    
    public bool Available { get; set; }
    
    public byte[]? Image { get; set; }
}
