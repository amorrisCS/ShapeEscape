using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button level1, level2, level3;

    void Start()
    {
        // checks for click to detemine which scene to load
        level1.onClick.AddListener(()=> Load("Level1Scene"));
        level2.onClick.AddListener(()=> Load("Level2Scene"));
        level3.onClick.AddListener(()=> Load("Level3Scene"));
        
    }

    void Load(string sceneName)
    {
        // loads scene upon the specific scene name clicked
        SceneManager.LoadScene(sceneName);
    }
}
