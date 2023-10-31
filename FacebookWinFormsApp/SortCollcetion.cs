using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class SortCollcetion<T>
    {
         private Func<T, T, bool> SortMethod { get; set; }

        public SortCollcetion(Func<T, T, bool> i_SortMethod)
        {
            SortMethod = i_SortMethod;
        }

        public List<T> MergeSort(List<T> i_Unsorted)
        {
            if (i_Unsorted.Count <= 1)
            {
                return i_Unsorted;
            }
                
            List<T> left = new List<T>();
            List<T> right = new List<T>();
            int middle = i_Unsorted.Count / 2;

            for (int i = 0; i < middle; i++) 
            {
                left.Add(i_Unsorted[i]);
            }

            for (int i = middle; i < i_Unsorted.Count; i++)
            {
                right.Add(i_Unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return merge(left, right);
        }

        private List<T> merge(List<T> i_Left, List<T> i_Right)
        {
            List<T> result = new List<T>();

            while (i_Left.Count > 0 || i_Right.Count > 0)
            {
                if (i_Left.Count > 0 && i_Right.Count > 0)
                {
                    if(SortMethod.Invoke(i_Left[0], i_Right[0]))
                    {
                        result.Add(i_Left[0]);
                        i_Left.Remove(i_Left[0]); 
                    }
                    else
                    {
                        result.Add(i_Right[0]);
                        i_Right.Remove(i_Right[0]);
                    }
                }
                else if (i_Left.Count > 0)
                {
                    result.Add(i_Left[0]);
                    i_Left.Remove(i_Left[0]);
                }
                else if (i_Right.Count > 0)
                {
                    result.Add(i_Right[0]);

                    i_Right.Remove(i_Right[0]);
                }
            }

            return result;
        }
    }
}
