namespace FirstApp
{
    class Employee : Person
    {
        // Булевый флаг, сообщающий, находится ли сотрудник на смене
        public bool IsOnShift;

        public Employee(string name, bool isOnShift) : base(name)
        {
            IsOnShift = isOnShift;
        }
    }
}
