﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess;

namespace DemoChess
{
    class Program
    {
        static void Main(string[] args)       {

            Random random = new Random();
            Chess.Chess  chess = new Chess.Chess();
            List<string> list ;

            while (true) {
               list = chess.GetAllMoves();
                Console.WriteLine(chess.fen);
                Console.WriteLine(chess.isCheck() ? "CHEK " : "-");            
                Console.WriteLine(ChessToAscii(chess) );
                foreach (string moves in list)
                  Console.Write(moves + "\n");
                Console.WriteLine();
                Console.Write("> ");
                string move = Console.ReadLine();
                if (move == "q" || move =="Q") break;
                if (move == "")
                    move = list[random.Next(list.Count)];
               chess = chess.Move(move);
            }
        }

        static string ChessToAscii(Chess.Chess chess) {

            string text = "  +-----------------+\n";
            for (int y = 7; y >= 0; y--) {
                text += y  +  1;
                text += " | ";
                for (int x = 0; x < 8; x++)  {
                    text += chess.getFigureAt(x, y) + " ";
                }
                text += "| \n";
            }
            text += "  +-----------------+\n";
            text += "    a b c d e f g h \n";
            return text;
        }
    }
}
