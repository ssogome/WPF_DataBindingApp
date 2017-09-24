﻿using System.Windows.Input;

namespace WPF_DataBindingApp.Helpers
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand Exit = new RoutedUICommand( "Exit", "Exit", typeof(CustomCommands), new InputGestureCollection()
               {
                    new KeyGesture(Key.F4, ModifierKeys.Alt)
               }
           );

        //Define more commands here, just like the one above
    }
}
