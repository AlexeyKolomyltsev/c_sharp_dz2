Console.WriteLine("Напишите номер четверти");
string number =Console.ReadLine();
if (number == "1") Console.WriteLine("Коордитаты x>0, y>0");
else if (number == "2") Console.WriteLine("Коордитаты x<0, y>0");
else if (number == "3") Console.WriteLine("Коордитаты x<0, y<0");
else if (number == "4") Console.WriteLine("Коордитаты x>0, y<0");
else Console.WriteLine("Нет такой плоскости");