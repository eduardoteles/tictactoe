using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        string[] line1;
        string[] line2;
        string[] line3;

        public Board()
        {
            line1 = new string[3] { "", "", "" };
            line2 = new string[3] { "", "", "" };
            line3 = new string[3] { "", "", "" };
        }

        public void addMarker(int row, int column, string marker)
        {
            switch(row)
            {
                case 1:
                    line1[column-1] = marker;
                    break;
                case 2:
                    line2[column-1] = marker;
                    break;
                case 3:
                    line3[column-1] = marker;
                    break;

            }
        }

        public string drawBoard()
        {
            string output = "\n";
            output += line1[0] + "  | " + line1[1] + "  | " + line1[2] + "\n";
            output += "- | - | - \n";
            output += line2[0] + "  | " + line2[1] + "  | " + line2[2] + "\n";
            output += "- | - | - \n";
            output += line3[0] + "  | " + line3[1] + "  | " + line3[2] + "\n";
            return output;
        }

        public Boolean checkVitory()
        {
            if ((line1[0] == line1[1] && line1[1] == line1[2]) && (line1[0]!="" && line1[1]!="" && line1[2]!=""))
            {
                return true;
            }
            else if((line1[0] == line2[0] && line2[0] == line3[0]) && (line1[0]!="" && line2[0]!="" && line3[0]!=""))
            {
                return true;
            }
            else if ((line2[0] == line2[1] && line2[1] == line2[2]) && (line2[0] !="" && line2[1] !="" && line2[2]!=""))
            {
                return true;
            }
            else if((line1[1] == line2[1] && line2[1] == line3[1]) && (line1[1] !="" && line2[1] != "" && line3[1] != ""))
            {
                return true;
            }
            else if ((line3[0] == line3[1] && line3[1] == line3[2]) && (line3[0] != "" && line3[1] != "" && line3[2]!=""))
            {
                return true;
            }
            else if((line1[2] == line2[2] && line2[2] == line3[2]) && (line1[2] != "" && line2[2] !="" && line3[2]!=""))
            {
                return true;
            }
            else if ((line1[0] == line2[1] && line2[1] == line3[2]) && (line1[0] != "" && line2[1] != "" && line3[2] != ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
