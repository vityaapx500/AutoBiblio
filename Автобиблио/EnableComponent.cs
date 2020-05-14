namespace Автобиблио
{
    class EnableComponent
    {
        public delegate void MyEvent(int userRole);
        public static MyEvent EventHandler;
    }
}