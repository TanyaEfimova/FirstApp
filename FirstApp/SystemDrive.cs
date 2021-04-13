using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    class SystemDrive : Drive
    {
        public SystemDrive(long reservedSpace)
        {
            ReservedSpace = reservedSpace;
        }

        public long ReservedSpace { get; }
    }
}
