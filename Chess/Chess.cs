using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Video  00:41

namespace Chess
{
    public class Chess    {

        public string fen { get; private set;}

        public Chess(string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1") {

            this.fen = fen;

        }

        public Chess Move(string move) {

            Chess nextChess = new Chess(fen);

            return nextChess;
        }

        public char getFingureAt(int x, int y) {
            return '.';
        }

    }
}
