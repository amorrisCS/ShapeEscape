using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainJump : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button Home;
    void Start()
    {
        // checks for click to detemine which scene to load
        Home.onClick.AddListener(()=> Load("MainMenu"));
        
    }
     void Load(string sceneName)
    {
        // loads scene upon the specific scene name clicked
        SceneManager.LoadScene(sceneName);
    }
}
