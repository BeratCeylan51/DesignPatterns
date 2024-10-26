using Strategy;

CreditCalculatorBase personalFinanceCreditCalculator = new PersonalFinanceCreditCalculator();
CreditCalculatorBase vehicleCreditCalculator = new VehicleCreditCalculator();
CustomerManager customerManager = new() { CreditCalculatorBase = personalFinanceCreditCalculator };
customerManager.SaveCredit();
customerManager.CreditCalculatorBase = vehicleCreditCalculator;
customerManager.SaveCredit();