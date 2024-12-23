using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SpyGamev1._0Csharp
{
    internal class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }  
        public Image Avatar { get; set; }
        public bool IsSpy { get; set; }
    }
}
