using UnityEngine;
using UnityEngine.UI;
using UnityProgrammingTheory.Scripts.Scene;

namespace UnityProgrammingTheory.Scripts.Menu
{
    public class MainMenuController : MonoBehaviour
    {
        [SerializeField]
        private Button _startBtn = null;
        [SerializeField]
        private Button _quitBtn = null;

        private void Awake()
        {
            SetupButtons();
        }

        private void SetupButtons()
        {
            _startBtn.onClick.AddListener(StartGame);
            _quitBtn.onClick.AddListener(QuitApp);
        }

        private void StartGame()
        {
            SceneManagerController.LoadScene(this, ScenesEnum.LEVEL_01);
        }

        private void QuitApp()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
        }
    }
}
