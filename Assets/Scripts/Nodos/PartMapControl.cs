using UnityEngine;
public class PartMapControl : MonoBehaviour
{
    private SpriteRenderer _compSpriteRenderer;
    private void Awake()
    {
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void SetSprite(Sprite sprite)
    {
        _compSpriteRenderer.sprite = sprite;
    }
}
