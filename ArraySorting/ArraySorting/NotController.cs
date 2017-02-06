using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySorting
{
    static class NotController
    {
        static View _view = new View();


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            BubbleSort(new int[] {66, 2, 5, 3, 1, 4, 8, 5, 66, 54});
            _view.UpdateText("Selection");
            
            PrintArray(SelectionSort(new int[] { 66, 2, 5, 3, 1, 4, 8, 5, 66, 54 }));
            Application.Run(_view);
        }

        static int[] BubbleSort(int[] input)
        {
            int[] output = (int[])input.Clone();
            bool swapped = false;
            for (int i = 0; i < output.Length - 1; i++)
            {
                PrintArray(output);
                if (output[i] > output[i + 1])
                {
                    int newValue = output[i + 1];
                    output[i + 1] = output[i];
                    output[i] = newValue;
                    swapped = true;
                }
                
            }

            if (swapped)
            {
                output = BubbleSort(output);
            }
            PrintArray(output);
            return output;
        }

        static int[] SelectionSort(int[] input)
        {
            int[] output = (int[])input.Clone();
            
            for (int i = 0; i < output.Length; i++)
            {
                int indexOf = i;
                int newValue = output[i];

                for (int j = i ; j < output.Length; j++)
                {
                    if (newValue >= output[j])
                    {
                        newValue = output[j];
                        indexOf = j;
                    }
                   
                }
                
                output[indexOf] = output[i];
                output[i] = newValue;
                
            }
            
            return output;
        }

        static void PrintArray(int[] array)
        {
            String line = "";
            foreach (int value in array)
            {
                line += value.ToString() + ", ";
            }
            _view.UpdateText(line);
        }
    }
}