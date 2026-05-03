using UnityEngine;

public class SkinManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static SkinManager Instance {get; private set;}

    [Header("Skins Swap")]
    public Sprite[] skins;
    public string[] skinNames;

    public int SelectedIndex { get; private set;} = 0;

    void Awake(){
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        SelectedIndex = PlayerPrefs.GetInt("SelectedSkin", 0);
    }

     public void SelectSkin(int index)
    {
        SelectedIndex = index;
        PlayerPrefs.SetInt("SelectedSkin", index);
    }

    public Sprite GetSelectedSprite() => skins[SelectedIndex];
    public string GetSelectedName()   => skinNames[SelectedIndex];
}


