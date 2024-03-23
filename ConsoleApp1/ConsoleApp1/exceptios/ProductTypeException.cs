using System.Runtime.Serialization;
namespace ConsoleApp1.exceptios;

public class ProductTypeException : Exception
{
    public ProductTypeException()
    {
        Console.WriteLine("Container mixing products hazard");
    }

    protected ProductTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        Console.WriteLine("Container mixing products hazard");
    }

    public ProductTypeException(string? message) : base(message)
    {
        Console.WriteLine("Container mixing products hazard");
    }

    public ProductTypeException(string? message, Exception? innerException) : base(message, innerException)
    {
        Console.WriteLine("Container mixing products hazard");
    }
}