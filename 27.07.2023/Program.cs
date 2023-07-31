using System;
using _27._07._2023;

Console.WriteLine("1.Qrup elave et:");
Console.WriteLine("2.Bütün qruplara bax:");
Console.WriteLine("3.Verilmiş point aralığındaki qruplara bax:");
Console.WriteLine("4.Verilmiş nömrəli qrupa bax:");
Console.WriteLine("5.Menudan cıx:");
Console.WriteLine("                             ");





do
{

    Console.WriteLine("Please enter number from 0 to 4 :");
    string Numberstr = Console.ReadLine();
    int Number = Convert.ToInt32(Numberstr);
    Course course = new Course();


    switch (Number)
    { 
        case 1:
            Console.WriteLine("Ne qeder qrup elave edeceksiniz?");
            int Count = int.Parse(Console.ReadLine());
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("Qrup nomresi daxil edin:");
                string no = Console.ReadLine();
                Console.WriteLine("Qrupun ortalamsini daxil edin:");
                double avgPoint = int.Parse(Console.ReadLine());
                Group group = new Group(no, avgPoint);
                course.AddGroup(group);


            }






            break;
        case 2:


            //course.AddGroup(group);

            foreach (Group groups in course.Groups)
            {
                Console.WriteLine($"Qrupun nomresi:{groups.No} and Qrupun ortalamasi:{groups.AvgPoint}");
            }
            


            break;
        case 3:

            break;
        case 4:
        course.GetGroupByNo("P234");


            break;
        case 0:
            Console.WriteLine("Proses bitti.");
            break;
        default:
    Console.WriteLine("Please enter valid Number(from 0 to 4):");
            break;
}
} while (true) ;