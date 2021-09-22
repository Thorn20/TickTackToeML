using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToeML
{
    //Neural Net takes board state array as input
    //Array contains 9 values, 0 = empty cell, 1 = Neural Net Cell, -1 = Opponents Cell
    //Neural Net outputs 9 values through SoftMax, showing the NN's "confidence" in a move to make
    class NeuralNet
    {
        public NeuralNet()
        {

        }

        public int MakeMove( string[] cells)
        {
            return new int();
        }
    }
}
