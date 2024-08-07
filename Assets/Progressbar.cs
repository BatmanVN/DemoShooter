using UnityEngine;

public partial class Progressbar : MonoBehaviour
{
    public RectTransform recTransform;
    public RectTransform mask;
    public RectTransform progressImage;

    private float maxWidth;
    private float maxHeight;

    private void Awake()
    {
        maxWidth = mask.rect.width;
        maxHeight = mask.rect.height;
    }

    public void SetProgressValue(float progress)
    {
        float currentWidth = Mathf.Clamp01(progress) * maxWidth;
        mask.sizeDelta = new Vector2(currentWidth, maxHeight);
    }
}
