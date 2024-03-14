
//Task1.
// Bir integer arrayi yaradın, daha sonra istifadəçidən yaşını soruşun,
// əgər istifadəçinin yaşı bu arrayda varsa true əks halda false çap edin


//int[] ages = { 21, 25, 27, 30, 35, 40, 57 };

//Console.WriteLine("Yasinizi daxil edin:");
//l1:
//if (int.TryParse(Console.ReadLine(), out int userAge))
//{
//    bool ageExists = false;
//    foreach (int age in ages)
//    {
//        if (age == userAge)
//        {
//            ageExists = true;
//            break;
//        }
//    }
//    Console.WriteLine(ageExists);
//}
//else
//{
//    Console.WriteLine("Reqem daxil edin!");
//    goto l1;
//}






//Task2.
//Bir a yararraydın, bu massivdə sinifdəki tələbələrin adlarını saxlasın.
//Sonra, istifadəçidən bir tələbə adı daxil etməsini istəyin. Əgər daxil edilən ad array-də varsa,
//"Tələbənin adını" çap edin, əks halda "Bu "Adda" Tələbə tapılmadı!" çap edin


string[] student = {"Ali","Nicat","Pasa","Vuqar","Aziz"};
l1:
Console.WriteLine("Adinizi daxil edin:");

string name=Console.ReadLine();

int count = 0;
foreach (string s in student)
{
    if (name == s)
    {
        count++;
    }
}
    if (count >= 1)
    {
        Console.WriteLine($"Telebenin adi:{name}");
    }
    else
    {
        Console.WriteLine($"Bu adda telebe yoxdu:{name}");
        goto l1;
    }





