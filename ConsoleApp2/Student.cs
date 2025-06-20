namespace ConsoleApp2;

public delegate void InterviewBasket(string name);

internal class Student
{
    public event InterviewBasket OnSelection;
    public event InterviewBasket OnRejection;
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; 
    public string Email { get; set; } = string.Empty;
    public int Marks { get; set; }

    public string CalculateResult()
    {
        if (Marks > 80)
        {
            OnSelection?.Invoke($"Name: {Name}, Email: {Email}");
            return $"{Name} has got distinction marks";
        }
        else
        {
            OnRejection?.Invoke($"Name: {Name}, Email: {Email}");
            return $"{Name} has got first class marks";
        }
    }
}