using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    void Start()
    {
        if (SkinManager.Instance != null)
        {
            // to change skin instance to what was selected in main menu
            GetComponent<SpriteRenderer>().sprite = SkinManager.Instance.skins[SkinManager.Instance.selected];
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}