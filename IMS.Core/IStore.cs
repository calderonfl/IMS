using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core
{

    public interface IStore
    {
        IInventory Local { get; }
    }
}
