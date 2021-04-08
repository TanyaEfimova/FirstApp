namespace FirstApp
{
    class SystemUnit
    {
        private MotherBoard motherBoard; //ассоциация

        //композиция
        public SystemUnit()
        {
            motherBoard = new MotherBoard();
        }

        //агрегация
        public SystemUnit(MotherBoard motherBoard)
        {
            this.motherBoard = motherBoard;
        }
    }
}
