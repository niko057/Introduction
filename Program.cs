
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

Console.WriteLine("Adinizi daxil edin:");

string name=Console.ReadLine();

bool nameExists = false;


foreach (string i in student)
{
    if (string.Equals(name, i, StringComparison.OrdinalIgnoreCase))
    {
        nameExists = true;
        break;
    }
}

if (nameExists)
{
    Console.WriteLine($"Telebenin adı: {name}");
}
else
{
    Console.WriteLine($"Bu adda telebe tapilmadi:{name}");
}




