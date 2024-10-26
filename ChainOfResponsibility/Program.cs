using ChainOfResponsibility;

Manager manager = new();
VicePresident vicePresident = new();
President president = new();

manager.SetSuccessor(vicePresident);
vicePresident.SetSuccessor(president);

Expense expense = new()
{
    Amount = 1200
};

manager.HandleExpense(expense);