Console.WriteLine("Zehmet olmasa adinizi, soyadinizi ve qrup nomrenizi daxil edin:");
Console.Write("AD:"); string name1 = Console.ReadLine();
Console.Clear();
Console.Write("SOYAD:"); string surname1 = Console.ReadLine();
Console.Clear();
Console.Write("QRUP NOMRESI:"); string group1 = Console.ReadLine();
Console.Clear();
Student student1 = new Student(name1, surname1,group1);

Console.WriteLine($"{group1} qrupunun telebesi {name1} {surname1} xos geldiniz, zehmet olmasa tehsil veziyyetinizi secerdiniz:");

chooseGraduation();

string choose = Console.ReadLine();
Console.Clear();
while (choose != default)
{
    Console.Clear();
    switch (choose)
    {
        case "1":
            Console.WriteLine("Size gelecek heyatinizda ugurlar!");
            return;
        case "2":
            Console.WriteLine("Zehmet olmasa imtahandan aldiginiz bali qeyd ederdiniz:");
            int point1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Student newChance = new Student(point1);
            return;
        default:
            Console.WriteLine("Zehmet olmasa duzgun secin!");
            chooseGraduation();
            choose = Console.ReadLine();
            break;
    }
}







static void chooseGraduation()
{
    Console.WriteLine("1.Mezun olmusam.");
    Console.WriteLine("2.Hele de tehsil aliram.");
}