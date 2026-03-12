namespace ArrayUtilsLib
{
    public class ArrayUtilsLib
    {
        public static int GetTheMax(int[] in_array)
        {
            int max = 0;

            foreach(var item in in_array)
            {
                if(item > max)
                {
                    max = item;
                }
            }

            return max;
        }
    }
}
