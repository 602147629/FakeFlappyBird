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

		private IViewManager viewMgr;

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
			viewMgr = new U3DViewManager ();
			viewLoader = new ViewLoader(viewMgr);
			ViewFlow = viewMgr.ViewFlow;
		}

        public void StartGame()
        {
            viewLoader.LoadView();		
			ViewFlow.Forward("WelcomeView");
        }
				
    }
}

