﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Infrastructure
{
    internal class GameHistory
    {
        public Stack<HeroMemento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<HeroMemento>();
        }
    }
}
