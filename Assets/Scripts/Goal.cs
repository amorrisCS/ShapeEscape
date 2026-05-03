using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{
    static public bool escaped = false;

    void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.tag == "Player")
        {
            Goal.escaped = true;
            SceneManager.LoadScene("Level3Scene");
            Material mat = GetComponent<Renderer>().material;
            Color color = mat.color;
            color.a = 0.5f;
            mat.color = color;
        }
    }

}
