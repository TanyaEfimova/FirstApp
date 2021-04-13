namespace FirstApp
{
    class Drive
    {
        public string Name { get; }
        public long Volume { get; }
        public long FreeVolume { get; }

        public Drive() { }

        public Drive(string name, long vol, long free)
        {
            Name = name;
            Volume = vol;
            FreeVolume = free;
        }
    }
}
