namespace Breeze_Soft_Test_Task.Data;

public class Car
{
    public int Id { get; set; }
    public string Producer { get; set; }
    public string Name { get; set; }
    public float EnginePower { get; set; }
    public int Engine { get; set; }
    public byte? AmountOfCylinders { get; set; }
    public string Color { get; set; }
    public DateOnly ProducedDate { get; set; }
    public bool Available { get; set; }
    public byte[]? Image { get; set; }
}
