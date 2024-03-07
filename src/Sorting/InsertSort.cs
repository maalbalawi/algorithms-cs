namespace Sorting
{
    public static class InsertSort 
    {       
       private static void exch<T>(T[] arr, int a, int b) where T:IComparable<T>{
            T temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
       }
        
        public static void Sort<T>(T[] arr)  where T:IComparable<T>
        {            
            int n = arr.Length;
            for (int i=0; i < n; i++) {
                for (int j = i; j > 0; j--) {
                    if (arr[j-1].CompareTo(arr[j]) > 0 ) {
                        exch(arr, j-1, j);                        
                    }
                    else
                        break;
                }
            }
        }
    }
    
}