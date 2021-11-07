
namespace DavrBank.Vash.Shared.Abstracts
{
    public interface IEntity<T> where T: struct
    {
        T Id { get; set; }
    }
}
