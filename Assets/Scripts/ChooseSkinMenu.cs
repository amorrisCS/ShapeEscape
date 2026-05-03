using UnityEngine;
using UnityEngine.UI;

public class ChooseSkinMenu : MonoBehaviour
{
    public Image preview;
    public Button skin1, skin2, skin3; // showcases following skins
    

    void Start()
    {
        skin1.onClick.AddListener(() => SelectSkin(0));
        skin2.onClick.AddListener(() => SelectSkin(1));
        skin3.onClick.AddListener(() => SelectSkin(2));
        // to see current sprite selected in preview
        preview.sprite = SkinManager.Instance.skins[SkinManager.Instance.selected];
    }

    void SelectSkin(int index)
    {
        SkinManager.Instance.selected = index;
        // show preview sprite for next one clicked
        preview.sprite = SkinManager.Instance.skins[index];
    }
}