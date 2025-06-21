using UnityEngine;
using UnityEngine.UI;

public class ScrollCreds : MonoBehaviour
{
    public Scrollbar scrollbar;

    public RectTransform contentToScroll;

    public RectTransform viewArea;

    private float scrollableHeight;




    void Start()
    {
        scrollableHeight = contentToScroll.rect.height - viewArea.rect.height;

        if (scrollableHeight < 0)
        {
            scrollableHeight = 0;
        }

        scrollbar.onValueChanged.AddListener(OnScrollbarMoved);

        OnScrollbarMoved(scrollbar.value);
    }

    private void OnScrollbarMoved(float value)
    {
        float newYPosition = Mathf.Lerp(scrollableHeight, 0, value);

        contentToScroll.anchoredPosition = new Vector2(contentToScroll.anchoredPosition.x, newYPosition);

    }
    void OnDestroy()
    {
        if (scrollbar != null)
        {
            scrollbar.onValueChanged.RemoveListener(OnScrollbarMoved);

        }
    }
}
