using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevelUI : MonoBehaviour
{
    [SerializeField] private Slider _loadBar;
    [SerializeField] private TMP_Text _loadProgress;
    public void StartLoadingLevel()
    {
        StartCoroutine(LoadSceneAsync());
    }
    private IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(1);
        while (!asyncLoad.isDone)
        {
            _loadBar.value = asyncLoad.progress;
            _loadProgress.text = $"{asyncLoad.progress * 100f} %";
            yield return null;
        }
    }
}
