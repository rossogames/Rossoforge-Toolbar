using System;

namespace Rossoforge.Toolbar.Editor.Callbacks
{
    [Serializable]
    public abstract class ButtonCallback
    {
        public virtual bool Enabled
        {
            get => true;
        }

        public abstract bool Invoke();
    }
}
