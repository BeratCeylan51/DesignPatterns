﻿namespace Proxy
{
    public class CreditManagerProxy : CreditBase
    {
        private CreditManager? _creditManager;
        private int _cachedValue;

        public override int Calculate()
        {
            if (_creditManager == null)
            {
                _creditManager = new CreditManager();
                _cachedValue = _creditManager.Calculate();
            }

            return _cachedValue;
        }
    }

    public abstract class CreditBase
    {
        public abstract int Calculate();
    }

    public class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;
            for (int i = 1; i <= 5; i++)
            {
                result *= i;
                Thread.Sleep(1000);
            }
            return result;
        }
    }
}
