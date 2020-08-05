using System;


namespace YazilimTasarim.ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler successor;

        public abstract void check(PageType type);

        public void succeedWith(Handler successor)
        {
            this.successor = successor;
        }

        public void next(PageType type)
        {
            if(successor != null)
            {
                successor.check(type);
            }
        }
    }
}
