﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Bomberman.GameEngine;
using Bomberman.Source;

namespace Bomberman
{

    static class Program
    {
        
        static void Main()
        {
            AbstractGameEngine game = new Game(new BombermanWindow());
            game.Start();
        }
    }
}
