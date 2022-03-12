using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "preetam";
            HashSet<char> s = new HashSet<char>();
            bool isFound = true;
            for(int i=0; i< name.Length; i++)
            {
                for(int j=i+1; j< name.Length; j++)
                {
                    if(name[i] == name[j])
                    {
                        
                    }
                    
                }
            }
        }
    }
}
