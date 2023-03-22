namespace HomeTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\Юлия\Desktop\BetrootHomeworks\HomeTask7\NewFile.txt";
            //if (!File.Exists(path))
            //{
            //    using (StreamWriter sw = File.CreateText(path))
            //    {
            //        sw.WriteLine("test");
            //    }
            //}

            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s;
            //    while((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}


            string path = @"C:\Users\Юлия\Desktop\BetrootHomeworks\HomeTask7\PhoneBook.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }


    }
}