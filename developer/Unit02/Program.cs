using Unit02;

namespace Unit02
{
    class Program{
        ///Begins the game !
        static int Main(string[] args){
            Director director = new Director();
            director.StartGame();
            return 0;
        }
    }
}