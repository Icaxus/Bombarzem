using Scripts.Utilities;
using UnityEngine.SceneManagement;

namespace Scripts.Managers
{
    public class GameManager : Singleton<GameManager>
    {
        public bool isGameStarted;
   
        private void OnEnable()
        {
            if (global::Scripts.Managers.Managers.Instance == null)
                return;

            //Application.targetFrameRate = 30;

            EventManager.OnGameRestart.AddListener(GameRestart);
        }

        private void OnDisable()
        {
            if (global::Scripts.Managers.Managers.Instance == null)
                return;

            EventManager.OnGameRestart.RemoveListener(GameRestart);
        }

        public void StartGame()
        {
            if (isGameStarted)
                return;
        
            EventManager.OnGameStart.Invoke();
            isGameStarted = true;

        }

    

        private void GameRestart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}