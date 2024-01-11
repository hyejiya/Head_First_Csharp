public class Guy
{
    public string _name;
    public int _cash;

    public void WriteMyInfo()
    {
        Console.WriteLine($"{_name} {_cash}");
    }

    public void GiveCash(int value)
    {
        if (_cash <= value) 
        {
            Console.WriteLine($"{value}를 소지하고 있지 않습니다");
        }

        if ( value <= 0 )
        {
            _cash -= value;
            Console.WriteLine("유효한 값이 아닙니다");
        }
        _cash -= value;
        Console.WriteLine($"{value}값을 전달했습니다");
        
    }

    public void ReceiveCash(int value)
    {
        if (value <= 0)
        {
            _cash -= value;
            Console.WriteLine("유효한 값이 아닙니다");
        }
        else
        {
            _cash += value;
            Console.WriteLine($"{_name}은 {value}를 받았습니다");
        }
        
    }

    static void Main1()
    {      
        Guy joe = new Guy() { _name = "Joe", _cash = 50 };
        Guy bob = new Guy() { _name = "Bob", _cash = 100 };

        while (true)
        {
            joe.WriteMyInfo();
            bob.WriteMyInfo();
            Console.Write("금액을 입력하세요 : ");
            string howMuch = Console.ReadLine();
            if (howMuch == "") return;
            if(int.TryParse(howMuch, out int amount))
            {
                Console.Write("누구에게 돈을 줄 것인가요 : ");
                string whichGuy = Console.ReadLine();
                if (whichGuy == "Joe")
                {
                    bob.GiveCash(amount);
                    joe.ReceiveCash(amount);
                }
                else if (whichGuy == "Bob")
                {
                    joe.GiveCash(amount);
                    bob.ReceiveCash(amount);
                }
                else
                    Console.WriteLine("'Joe', 'Bob'중 입력해주세요");
            }
            else
            {
                Console.WriteLine("값을 입력해주세요 (빈칸을 입력하면 종료됩니다)");
            }
        }
    }
}