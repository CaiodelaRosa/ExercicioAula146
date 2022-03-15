namespace ExercicioAula146.Entities
{
    class PhysicalPerson : Person
    {
        public double HealthExpenditures { get; set; }

        public PhysicalPerson(string name, double annualIncome, double healthExpenditures)
            : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0;
            if (AnnualIncome < 20000.00)
            {
                tax = AnnualIncome * 0.15;
            }
            else
            {
                tax = AnnualIncome * 0.25;
            }

            return tax = tax - (HealthExpenditures * 0.50);
        }
    }
}
