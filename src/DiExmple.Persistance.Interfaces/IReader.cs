using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiExmple.Persistance.Interfaces
{
	public interface IReader<T>
    {
		Task<IEnumerable<T>> Read();
    }
}
