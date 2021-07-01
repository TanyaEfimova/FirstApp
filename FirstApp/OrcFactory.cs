using System;

namespace FirstApp
{
    class OrcFactory : IMonsterFactory
    {
        public IMovement CreateMovement()
        {
            return new RunMovement();
        }

        public IWeapon CreateWeapon()
        {
            return new Axe();
        }
    }
}
