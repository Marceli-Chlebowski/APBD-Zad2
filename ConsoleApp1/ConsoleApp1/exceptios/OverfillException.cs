using System.Runtime.Serialization;

namespace ConsoleApp1.exceptios;

public class OverfillException : Exception
{
    public OverfillException()
    {
        Console.WriteLine("Container Overfill hazard");
    }

    protected OverfillException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        Console.WriteLine("Container Overfill hazard");
    }

    public OverfillException(string? message) : base(message)
    {
        Console.WriteLine("Container Overfill hazard");
    }

    public OverfillException(string? message, Exception? innerException) : base(message, innerException)
    {
        Console.WriteLine("Container Overfill hazard");
    }
}