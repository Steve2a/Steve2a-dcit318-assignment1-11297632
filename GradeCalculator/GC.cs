namespace GradeCalculatorApp
{
    public class GradeCalculator
    {
        private int _numericalGrade;
        public int NumericalGrade
        {
            get { return _numericalGrade; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _numericalGrade = value;
                }
                else
                {
                    Console.WriteLine("Your grade is invalid. Select between 0 and 100");
                }
            }
        }
        public string CalcLetterGrade()
        {
            if (NumericalGrade >= 90)
                return "A";
            else if (NumericalGrade >= 80)
                return "B";
            else if (NumericalGrade >= 70)
                return "C";
            else if (NumericalGrade >= 60)
                return "D";
            else
                return "F";

                
        }

    }
}