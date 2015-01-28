namespace Game
{
    public class GameStart
    {      

        readonly ViewInitializer viewInit;

        public GameStart(ViewInitializer viewInit)
        {
            this.viewInit = viewInit;

        }

        public ViewInitializer ViewInit
        {
            get
            {
                return viewInit;
            }
        }

        public void Start()
        {
            viewInit.InitView();
        }
				
    }
}

