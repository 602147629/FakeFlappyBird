using CX.MVP.View;
using CX.U3D.MVP.View;
using CX.U3D.Character;
using CX.Character;
using CX.Obj;

namespace Game
{
    public class GameFacade
    {
        private ViewLoader viewLoader;

		public static IGameFlow GameFlow;

		public static IViewFlow ViewFlow;

		public static IViewManager ViewMgr;

        public GameFacade()
        {
			InitGame();
			InitView();
        }

		private void InitGame()
		{
			GameFlow = new GameFlowController(); 
		}

		private void InitView()
		{
			ViewMgr = new U3DViewManager ();
			viewLoader = new ViewLoader(ViewMgr);
			ViewFlow = ViewMgr.ViewFlow;
		}

        public void StartGame()
        {
            viewLoader.LoadView();		
			ViewFlow.Forward("WelcomeView");
        }
				
    }
}

