using OSIM.UnitTests.OSIM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSIM.OSIM.Core.Persistance
{
    public interface IItemTypeRepository
    {
        int Save(ItemType itemType);
    }
    public class ItemTypeRepository : IItemTypeRepository
    {
        public int Save(ItemType itemType)
        {
            throw new NotImplementedException();
        }

    }
}