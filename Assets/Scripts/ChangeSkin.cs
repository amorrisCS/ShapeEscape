using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
     private SpriteRenderer sr;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        ApplySkin();
    }

    public void ApplySkin()
    {
        if (SkinManager.Instance != null)
        {
            // pulls selected sprite from skin manager options
            sr.sprite = SkinManager.Instance.GetSelectedSprite();
            // changes green hue to white 
            sr.color = Color.white;
        }
    }
}
