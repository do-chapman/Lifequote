using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifequote
{
    class dob
    {
    public static int LookUpTable< TRange, TValue > (IList < TRange > ranges, TValue value, IRangeComparer< TRange, TValue > comparer)
    where TRange : Range<TValue> // Specify what you know about TRange and TValue
    where TValue:
            IComparable < TValue >
{
                int indexToTable = BinarySearch(ranges, value, comparer);
                TRange lookUp = ranges[indexToTable]; // lookUp is TRange, not Range<TRange>
                return lookUp.Value;
            }
        }
    }
}
