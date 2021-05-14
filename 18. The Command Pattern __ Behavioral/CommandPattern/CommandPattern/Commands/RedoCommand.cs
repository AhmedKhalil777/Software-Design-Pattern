namespace CommandPattern
{
    public class RedoCommand : ICommand
    {
        private readonly IReciever _reciever;

        public RedoCommand(IReciever reciever)
        {
            _reciever = reciever;
        }
        public void DO()
        {
            _reciever.OptionalTaskPriorToRedo();
            _reciever.PerformRedo();
        }
    }
}
