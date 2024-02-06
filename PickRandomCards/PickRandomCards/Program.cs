using PickRandomCards;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of card to pick : ");
        string line = Console.ReadLine();

        if(int.TryParse(line, out int numberOfCards))
        {
            foreach (string card in CardPicker.PickSomeCards(numberOfCards))
            {
                Console.WriteLine(card);
            }
        }
        else
        {
            Console.WriteLine("입력값이 유효하지 않습니다");
        }

    }

}
