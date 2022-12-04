// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Задание должно быть выполнено в методе. 
// В методе не должно быть вывода в консоль. Не использовать String!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = int.Parse(Console.ReadLine());
int result = CheckingForPalindrome(number);

if (result == 1) {
    Console.WriteLine("Yes");
} if (result == 0) {
    Console.WriteLine("No");
} else {
    Console.WriteLine("Not a five-digit number");
}

int CheckingForPalindrome(int number)
{

    string str = number.ToString();
    int strLenght = str.Length;

    if (strLenght == 5) {

        if (str[0] == str[4] && str[1] == str[3]) {
            return 1;
        }
        else {
            return 0;
        }

    }

    return -1;
}
