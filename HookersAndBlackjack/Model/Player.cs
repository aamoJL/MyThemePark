using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookersAndBlackjack.Model
{
    class Player
    {
        private string Name { get; set; }
        /// <summary>
        /// 1 = Human, 4 = House, 2 = Easy, 3 = Hard
        /// </summary>
        private int AI { get; set; }

        public Player(string name, int ai)
        {
            Name = name;
            AI = ai;
        }

        private void Surrender()
        {
            throw new NotImplementedException();
        }

        private void Split()
        {
            throw new NotImplementedException();
        }

        private void DoubleDown()
        {
            throw new NotImplementedException();
        }

        private void Stand()
        {
            throw new NotImplementedException();
        }

        private void Hit()
        {
            throw new NotImplementedException();
        }

        private void Raise()
        {
            throw new NotImplementedException();
        }
    }

    
}
