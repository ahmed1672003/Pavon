namespace Pavon.Domain.Bases.Exceptions;
public class BaseEntityNotFoundException : Exception
{
    public BaseEntityNotFoundException(string? messsage = "Entity Not Found Exception") : base(messsage) { }
    public BaseEntityNotFoundException(string? messsage = "Entity Not Found Exception", Exception? innerException) : base(messsage, innerException) { }
}
