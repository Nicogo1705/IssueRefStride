using Stride.Engine;

namespace TestIssue
{
    class TestIssueApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
