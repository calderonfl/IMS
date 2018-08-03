using System.Collections.Generic;

namespace IMS.Core
{
    public interface IInventoryManager
    {
        ICollection<IStore> Stores { get; }
    }
}
