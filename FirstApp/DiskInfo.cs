namespace FirstApp
{
    class DiskInfo
    {
        public string Name { get; }
        public long Volume { get; }
        public long FreeVolume { get; }

        public DiskInfo(string name, long vol, long free)
        {
            Name = name;
            Volume = vol;
            FreeVolume = free;
        }

    }
}
