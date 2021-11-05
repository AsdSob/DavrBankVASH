
namespace VASHApi.Entities.Abstracts
{
    public interface IEntity<T> where T: struct
    {
        T Id { get; set; }
    }
}
