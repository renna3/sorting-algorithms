        
        //selection sort
        public static void selection_sort(int[] arr)
        {
            int imin = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[imin])             //trovo l'indice della cella col valore più piccolo
                        imin = j;
                }

                if (i != imin)
                {
                    int temp = arr[i];
                    arr[i] = arr[imin];
                    arr[imin] = temp;
                }
                
            }
        }
