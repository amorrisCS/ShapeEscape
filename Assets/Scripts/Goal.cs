using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{
    static public bool escaped = false;

    void OnTriggerEnter2D(Collider2D other)
    { 
        Debug.Log("Something hit the goal: " + other.tag);
        if (other.tag == "Player")
        {
            Goal.escaped = true;

            // repurposed into switch statement SceneManager.LoadScene("Level3Scene");
            string sceneName = SceneManager.GetActiveScene().name;
            switch(sceneName)
            {
                case "Level1Scene":
                SceneManager.LoadScene("Level2Scene");
                break;

                case "Level2Scene":
                SceneManager.LoadScene("Level3Scene");
                break;

                case "Level3Scene":
                SceneManager.LoadScene("VictoryScene");
                break;
            }

            Material mat = GetComponent<Renderer>().material;
            Color color = mat.color;
            color.a = 0.5f;
            mat.color = color;
        }
    }

}
