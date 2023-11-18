

using System.Text;

namespace DZ_c_dies_774
{
    internal class Program
    {
        public static string str1 = "C:\\Users\\User\\Desktop\\C#\\DZ_c_dies_774\\DZ_c_dies_774\\mmm.txt";
        public static string str2 = "C:\\Users\\User\\Desktop\\C#\\DZ_c_dies_774\\DZ_c_dies_774\\mmm2.txt";
        static async Task Main(string[] args)
        {        
            List<string[]> LISTA1 = new List<string[]>();                                     
            using (StreamReader reader = new StreamReader(str1))
            {
                string stroka;
                while ((stroka = await reader.ReadLineAsync()) != null)          
                {
                    string[] mass = stroka.Split(new char[] { ' ' ,'\t'}, StringSplitOptions.RemoveEmptyEntries);       
                    if (mass != null && mass.Length > 0)           
                    {
                        LISTA1.Add(mass);
                    }

                }
            }
            for (int i = 0; i < LISTA1.Count; ++i)                 
            {
                for (int j = 0; j < LISTA1[i].Length; ++j)
                {
                    if (LISTA1[i][j].Equals("public"))            
                    {
                        LISTA1[i][j] = "private";
                    }
                    if (LISTA1[i][j].Length > 2)                   
                    {
                        LISTA1[i][j] = LISTA1[i][j].ToUpper();
                    }
                    StringBuilder SLOVO = new StringBuilder();
                    for (int k = LISTA1[i][j].Length - 1; k >= 0; --k) 
                    {
                        SLOVO.Append(LISTA1[i][j][k]);
                    }
                    LISTA1[i][j] = SLOVO.ToString();                 
                    Console.Write(LISTA1[i][j] + " ");
                }
                Console.WriteLine();
            }

            using (StreamWriter vrrr = new StreamWriter(str2, false))    
            {
                for (int i = 0; i < LISTA1.Count; i++)                     
                {
                    StringBuilder strB = new StringBuilder();
                    for (int j = 0; j < LISTA1[i].Length; j++)             
                    {
                        strB.Append(LISTA1[i][j] + " ");
                    }
                    vrrr.WriteLine(strB.ToString());                         
                }
            }
            return ;
        }
    }
}