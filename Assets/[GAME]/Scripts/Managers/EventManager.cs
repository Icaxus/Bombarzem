using Scripts.Utilities;
using UnityEngine.Events;

namespace Scripts.Managers
{
    public class EventManager : Singleton<EventManager>
    {
            public static UnityEvent OnGameStart = new UnityEvent();
            public static UnityEvent OnGameEnd = new UnityEvent();
            public static UnityEvent OnGameRestart = new UnityEvent();
            public static UnityEvent OnSceneLoad = new UnityEvent();
    
            public static UnityEvent OnLevelStart = new UnityEvent();
            public static UnityEvent OnLevelFinish = new UnityEvent();
    
            public static UnityEvent OnLevelSuccess = new UnityEvent();
            public static UnityEvent OnLevelFail = new UnityEvent();
    }
}
