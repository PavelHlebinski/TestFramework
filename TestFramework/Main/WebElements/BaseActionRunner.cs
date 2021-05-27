using System;

namespace TestFramework.Main.WebElements
{
    public abstract class BaseActionRunner
    {
        protected T Execute<T>(Func<T> check)
        {
            try
            {
                return check();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        protected void Execute(Action check)
        {
            try
            {
                check();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
