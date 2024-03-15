using System;
namespace c_sharp { 
    class program
{
    
    public static void Main(string[] args)
    {
            char[] s1 = "rasp".ToCharArray();
            char[] s2 = "pars".ToCharArray();
            if (Anagram(s1, s2))
            {
                Console.WriteLine("The two strings are anagram of each other");
            }
            else
            {
                Console.WriteLine("The two strings are not anagram of each other");
            }
        }
        public static bool Anagram(char[] s1, char[] s2)
        {
            int n1 = s1.Length;
            int n2 = s2.Length;
            //check whether the size of the both string is same or not
            if (n1 != n2)
            {
                return false;
            }
            //sort two string
            Array.Sort(s1);
            Array.Sort(s2);
            //compare 
            for (int i = 0; i < n1; i++)
            {
                if (s1[i] != s2[i])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
