using System.ComponentModel.Design;
using System.Text;

class RandomNumberGenerator
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        Console.WriteLine("Welcome to the Game 'Guess the number!'");
        Console.WriteLine("I Guessed a number between: 1 and 100.");
        Console.WriteLine("Try to guess it.");

        Random random = new Random();
        int RandNum = random.Next(100);
        int count = 1;
        int UserNumber = Convert.ToInt32((Console.ReadLine()));
        

            while (count <= 10)

                if (UserNumber == RandNum)

                {
                    Console.WriteLine("Congratulations! You won!");
                    break;
                }
                else if (UserNumber > RandNum)
                {
                    count++;
                    Console.WriteLine("The number that I guessed is smaller than this");
                    UserNumber = Convert.ToInt32((Console.ReadLine()));
                }

                else if (UserNumber < RandNum)
                {
                    count++;
                    Console.WriteLine("The number that I guessed is bigger than this");
                    UserNumber = Convert.ToInt32((Console.ReadLine()));
                }
                else if (count == 10)
                {
                    Console.WriteLine("Sorry you lost. The number that I guessed is " + RandNum + "." + "Please try again!");
                    break;
                }
                else
                {
                    Console.WriteLine("Error. Please enter a number");
                }
            

        }


        // Так же помним что надо проверять ввод пользователя на корректность
        // Если пользователь ввел не число, то выводим сообщение об ошибке и просим ввести число еще раз
        // Число джолжно быть в диапазоне от 1 до 100 и целое

    }
