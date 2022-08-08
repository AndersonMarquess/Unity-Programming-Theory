using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityProgrammingTheory.Scripts.Scene
{
    public class SceneManagerController
    {
        public static void LoadScene(MonoBehaviour mono, ScenesEnum scene)
        {
            int sceneIndex = (int)scene;
            mono.StartCoroutine(LoadSceneRoutine(sceneIndex));
        }

        private static IEnumerator LoadSceneRoutine(int sceneIndex)
        {
            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneIndex);
            asyncOperation.allowSceneActivation = true;
            yield return asyncOperation;
        }
    }
}
