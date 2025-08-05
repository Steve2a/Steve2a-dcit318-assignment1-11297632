namespace TicketCalcApp
{
    public class TicketCalculator
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0 && value <= 120)
                    _age = value;
                else
                {
                    Console.WriteLine("Wrong age");
                    _age = 0;
                }
            }
        }

        public int CalcPrice()
        {
            if (_age <= 12 || _age >= 65)
                return 7;
            else
                return 10;
        }
    }
}