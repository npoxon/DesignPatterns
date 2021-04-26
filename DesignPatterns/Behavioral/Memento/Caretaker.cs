using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Behavioral.Memento
{
    // The Caretaker doesn't depend on the Concrete Memento class. Therefore, it
    // doesn't have access to the originator's state, stored inside the memento.
    // It works with all mementos via the base Memento interface.
    public class Caretaker
    {
        private readonly List<IMemento> _mementos = new List<IMemento>();
        private readonly Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                return;
            }

            var memento = _mementos.Last();
            _mementos.Remove(memento);
            
            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public List<string> ShowHistory()
        {
            return _mementos.Select(memento => memento.GetName()).ToList();
        }
    }
}