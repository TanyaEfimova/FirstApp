namespace FirstApp
{
    /// <summary>
    ///  Интерфейс абстрактной фабрики
    /// </summary>
    interface IMonsterFactory
    {
        IMovement CreateMovement();
        IWeapon CreateWeapon();
    }
}
