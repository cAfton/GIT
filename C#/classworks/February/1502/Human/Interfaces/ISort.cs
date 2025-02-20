using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human.Interfaces
{
    public interface ISort
    {
        void SortAsc();

        void SortDesc();

        void SortByParam(bool order);
    }
}
