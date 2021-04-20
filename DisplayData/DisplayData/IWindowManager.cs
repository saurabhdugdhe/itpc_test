using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DisplayData
{
    interface IWindowManager
    {
        /// <summary>
        /// This method closes the window.
        /// </summary>
        void CloseWindow();

        Window GetWindow();
    }
}
