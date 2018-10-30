using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiExmple.Services.Interfaces
{
	public interface IProvider<T>
    {
        Task<IEnumerable<T>> GetValues();
    }
}
