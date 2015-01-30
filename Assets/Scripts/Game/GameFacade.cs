using CX.MVP.View;
using CX.U3D.MVP.View;
using CX.U3D.Character;
using CX.Character;

namespace Game
{
    public class GameFacade
    {
        private ViewLoader viewLoader;

		private IGameFlow gameFlow;

		private IViewManager viewMgr;

		private IViewFlow viewFlow;

        public GameFacade()
        {
			InitGame();
			InitView();
        }

		private void InitGame()
		{
			gameFlow = new GameFlowController ();
		}

		private void InitCharacter()
		{
			CharacterFactory characterFactory = new CharacterFactory();
			ICharacter character = characterFactory.Create("bird");
		}

		private void InitView()
		{
			viewMgr = new U3DViewManager ();
			viewLoader = new ViewLoader(viewMgr);
			viewFlow = viewMgr.ViewFlow;
		}

        public void StartGame()
        {
            viewLoader.LoadView();		
			viewFlow.Forward("WelcomeView");
        }
				
    }
}

