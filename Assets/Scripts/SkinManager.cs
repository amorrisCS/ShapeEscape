using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public static SkinManager Instance;
    public Sprite[] skins;
    public int selected = 0;

    void Awake()
    {
        if (Instance != null) { Destroy(gameObject); return; }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}