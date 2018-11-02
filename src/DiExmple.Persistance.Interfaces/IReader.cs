using System.Threading.Tasks;

namespace DiExmple.Persistance.Interfaces
{
	public interface IReader<T>
    {
		Task<T> Read();
    }
}
