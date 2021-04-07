namespace FirstApp
{
    class InheritedClass : BaseClass
    {
        private int newValue;

        public InheritedClass(int newValue) : base("100")
        {
            this.newValue = newValue;
        }
    }
}
