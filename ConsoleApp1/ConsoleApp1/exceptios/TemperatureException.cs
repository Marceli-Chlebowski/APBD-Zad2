using System.Runtime.Serialization;
namespace ConsoleApp1.exceptios;

public class TemperatureException : Exception
{
    public TemperatureException()
    {
        Console.WriteLine("Container temperature hazard");
    }

    protected TemperatureException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        Console.WriteLine("Container temperature hazard");
    }

    public TemperatureException(string? message) : base(message)
    {
        Console.WriteLine("Container temperature hazard");
    }

    public TemperatureException(string? message, Exception? innerException) : base(message, innerException)
    {
        Console.WriteLine("Container temperature hazard");
    }
}