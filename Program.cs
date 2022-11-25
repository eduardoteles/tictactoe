namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean winner = false;
            Board TicTacToeBoard = new Board();
            int row;
            int column;
            string marker;

            Console.WriteLine("Bem vindo ao Tic-Tac-Toe\n\n");
            Console.Write(TicTacToeBoard.drawBoard());
            do
            {
                Console.WriteLine("Introduza a linha:");
                row = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduza a coluna:");
                column = int.Parse(Console.ReadLine());
                Console.WriteLine("X ou O ?");
                marker = Console.ReadLine();

                TicTacToeBoard.addMarker(row, column, marker);
                Console.Write(TicTacToeBoard.drawBoard());
                if (TicTacToeBoard.checkVitory()==true)
                {
                    winner = true;
                    Console.WriteLine("Parabéns, temos vencedor para o " + marker);
                }
            }
            while (winner == false) ;
        }
    }
}