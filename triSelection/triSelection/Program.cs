using System;

namespace triSelection
{
    class Program
    {
        static void triSelection(ref int[] tab)
        {
            int x;
            int n = tab.Length;

            for(int i = 0; i <= n - 2; i++)
            {
                int min = i;

                for(int j = i + 1; j <= n - 1; j++)
                {
                    if(tab[j] < tab[min])
                    {
                        min = j;
                    }
                }

                if(min != i)
                {
                    x = tab[min];
                    tab[min] = tab[i];
                    tab[i] = x;
                }

            }
        }
        

        static void triBulle(ref int[] tab)
        {
            int passage = 0;
            int n = tab.Length;
            bool permut;
            do
            {
                permut = false;
                for(int i = 0; i <= n - 2 - passage; i++)
                {
                    if(tab[i] > tab[i + 1])
                    {
                        int tanpon = tab[i + 1];
                        tab[i + 1] = tab[i];
                        tab[i] = tanpon;
                        permut = true;
                    }
                }

                passage = passage + 1;
            }
            while (permut);
        }

        static void triShell(ref int[] tab)
        {
            int n = tab.Length;
            int EC = n / 2;
            bool permut;

            while(EC >= 1)
            {
                do
                {
                    permut = false;
                    
                    for(int i  = 0; i <= n - 1 - EC; i++)
                    {
                        if (tab[i] > tab[i + EC])
                        {
                            int tanpon = tab[i];
                            tab[i] = tab[i + EC];
                            tab[i + EC] = tanpon;
                            permut = true;

                        }
                    }
                }
                while (permut);

                EC = EC / 2;
            }
        }

        static void affichage(int[] tab, out string result)
        {
            result = "";

            for(int n = 0; n < tab.Length; n++)
            {
                result = result + "-" + tab[n];
            }

            Console.WriteLine(result);
        }


        static void Main(string[] args)
        {
            int[] tab;
            tab = new int[10] { 10, 55, 13, 5, 18, 2, 99, 4, 58, 1 };
            string result;

            // triSelection(ref tab);
            // triBulle(ref tab);
            //triShell(ref tab);
            affichage(tab, out result);

            Console.ReadLine();
        }
    }
}
