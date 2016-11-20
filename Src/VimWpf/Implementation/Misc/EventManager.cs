using System;
using System.Collections.Generic;

namespace Vim.UI.Wpf
{
    public static class EventManager
    {
        private static Action<string> _statusAction;
        public static void AddListener(Action<string> listener)
        {
            _statusAction += listener;
        }
        public static void RemoveListener(Action<string> listener)
        {
            _statusAction -= listener;
        }
        public static void BroadCastEvent(string str)
        {
            if(_statusAction!=null)
            {
                _statusAction(str);
            }
        }
    }
}
