namespace ChainOfResponsibility
{
    public abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase? Successor { get; set; }
        public abstract void HandleExpense(Expense expense);

        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            Successor = successor;
        }
    }

    public class Expense
    {
        public string? Detail { get; set; }

        public decimal Amount { get; set; }
    }

    public class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount <= 100)
            {
                Console.WriteLine("Manager approved the expense");
            }
            else
            {
                Successor?.HandleExpense(expense);
            }
        }
    }

    public class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount <= 1000)
            {
                Console.WriteLine("Vice President approved the expense");
            }
            else
            {
                Successor?.HandleExpense(expense);
            }
        }
    }

    public class President : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 1000)
            {
                Console.WriteLine("President approved the expense");
            }
        }
    }
}
