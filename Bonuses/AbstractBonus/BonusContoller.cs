using GameObjects.Player;
using Interfaces;

namespace Bonuses
{
    public abstract class BonusContoller : IUpdatable, IInteractable
    {
        
        
        public abstract void UpdateTick();
        public abstract void Interact(PlayerModel playerModel);

    }
}