//bubble sort
        public static void bubble_sort(int[] arr)
        {
            bool scambio = true;
            int i = 0;

            while (i < arr.Length - 1 && scambio)
            {
                scambio = false;
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j+1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        scambio = true;
                    }
                }
                i++;
            }
        }
