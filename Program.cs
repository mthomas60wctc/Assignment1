char response;
string datFile = "marioData.txt";
do
{
    Console.WriteLine("1: View Records\n2: Add Record\n3: Reset Records\n0: Exit");
    response = Console.ReadKey().KeyChar;
    Console.WriteLine();
    switch (response){
        case '1':
            Console.WriteLine("Displaying Data");
            StreamReader sr = new StreamReader(datFile);
            while (!sr.EndOfStream){
                string line = sr.ReadLine() ?? "";
                string[] lineArr = line.Split('|');
                Console.WriteLine("{0}, {1}", lineArr[0], lineArr[1]);
            }
            sr.Close();
        break;
        case '2':
            StreamWriter sw = new StreamWriter(datFile, append: true);
            Console.Write("Enter Name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Enter Description: ");
            string desc = Console.ReadLine() ?? "";
            sw.WriteLine("{0}|{1}", name, desc);
            sw.Close();
        break;
        case '3':
            Console.Write("Are you sure?");
            if (Char.ToLower(Console.ReadKey().KeyChar) == 'y') File.Delete(datFile);
        break;
    }
}while (response != '0');
Console.WriteLine("Ciao!");
