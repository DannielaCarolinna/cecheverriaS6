using System;
using System.Collections.Generic;
using System.Text;

namespace cecheverriaS6
{
    public interface Message
    {
        void LongAlert(string message);
        void ShortAlert(string message);
    }
}
