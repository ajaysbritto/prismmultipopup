using Prism.Commands;
using System.ComponentModel.Composition;

namespace Infrastructure
{

    public static class MyCommandCommands
    {
        private static CompositeCommand showOrderDetailsCommand = new CompositeCommand(true);

        public static CompositeCommand ShowOrderDetailsCommand
        {
            get { return showOrderDetailsCommand; }
            set { showOrderDetailsCommand = value; }
        }
    }

    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class MyCommandProxy
    {
        virtual public CompositeCommand ShowOrderCommand
        {
            get { return MyCommandCommands.ShowOrderDetailsCommand; }
        }
    }
}
