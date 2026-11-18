// Idle Transfiguration
// Blade & Sorcery: Nomad
// Initial development placeholder

using System;

namespace IdleTransfiguration
{
    public class IdleTransfigurationSpell
    {
        public bool IsActive { get; private set; }

        public void ToggleTransfiguration()
        {
            IsActive = !IsActive;
        }
    }
}
