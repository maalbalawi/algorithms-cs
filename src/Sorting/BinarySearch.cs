using System.Security.Cryptography.X509Certificates;

namespace Algorithms.Sorting
{
    public static class BinarySearch   {      
         private static int IndexOf<T>(T[] arr, int lo, int hi, T t) where T:  System.IComparable<T> {                
            while (hi >= lo)   {             
                int mid = lo + (hi - lo) / 2;
                int cmp = arr[mid].CompareTo(t);                
                // search left side
                if (cmp > 0) {
                    hi = mid-1;
                }
                //search right side
                else if (cmp < 0) {
                    lo = mid + 1;
                }                
                else 
                    return mid;
                
            }
            return -1;

        }
        public static int IndexOf<T>(T[] arr, T t) where T:  System.IComparable<T> {
            return IndexOf(arr, 0 , arr.Length, t);
        }
    
}
}