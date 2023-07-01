using System;
namespace CommandPattern.Commands
{
    public class UndoCommand : ICommand
    {
        private IReciever _reciever;
        public UndoCommand(IReciever reciever)
        {
            _reciever = reciever;
        }
        public void DO()
        {
            _reciever.OptionalTaskPriorToUndo();
            _reciever.PerformUndo();
        }
    }
}
