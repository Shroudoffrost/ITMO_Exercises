using System;
using System.Windows.Input;

namespace NCommand
{
    internal class CustomCommands
    {
        public static RoutedUICommand Launch { get; }

        static CustomCommands()
        {
            InputGestureCollection myInputGestures = new 
                InputGestureCollection();

            myInputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Control));
            Launch = new RoutedUICommand("Запуск", "Launch", typeof(CustomCommands), myInputGestures);
        }
    }
}
