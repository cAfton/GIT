using Human.Interfaces;
using Human.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    internal class Array : ISort, IEnumerable/*<IComparable>*/
    {
        public List<Humen> HumanList {  get; set; }

        //public IEnumerator<IComparable> GetEnumerator()
        //{
        //    return HumanList.GetEnumerator();
        //}

        public void SortAsc()
        {
            HumanList.Sort();
        }

        public void SortByParam(bool order)
        {
            if (order)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

        public void SortDesc()
        {
            HumanList.Sort();
            HumanList.Reverse();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return HumanList.GetEnumerator();
        }
    }
}
