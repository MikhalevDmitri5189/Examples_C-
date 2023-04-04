Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "маша") // ToLower переводит все буквы в нижний регистр.
                                  // Можно вводить имя Маша с большой или мальнькой буквы.
{
    Console.WriteLine("Ура это же Маша");
}

else
{
    Console.WriteLine("Привет,");
    Console.WriteLine(username);
}



