using Interfaces;

namespace Bonuses
{
    public abstract class BonusController : IUpdatable, IInteractable
    {
        public abstract void UpdateTick();

        public abstract void Interact();

    }
}