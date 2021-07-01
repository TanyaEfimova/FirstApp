using System;

namespace FirstApp
{
    class DragonFactory : IMonsterFactory
    {
        public IMovement CreateMovement()
        {
            return new FlyMovement();
        }

        public IWeapon CreateWeapon()
        {
            return new FireBreath();
        }
    }
}
