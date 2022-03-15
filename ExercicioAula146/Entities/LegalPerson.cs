namespace ExercicioAula146.Entities
{
    class LegalPerson : Person
    {
        public int Employees { get; set; }

        public LegalPerson(string name, double annualIncome, int employees)
            : base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            double tax = 0;

            if (Employees > 10)
            {
                tax = AnnualIncome * 0.14;
            }
            else
            {
                tax = AnnualIncome * 0.16;
            }
            return tax;
        }
    }
}
