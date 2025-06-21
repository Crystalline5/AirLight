using UnityEngine;
using TMPro;

public class Preview : MonoBehaviour

{
    public TMP_InputField InputFieldIn;

    public TextMeshProUGUI TEXTPREVIEW;

    void Start()

    {
        if (InputFieldIn != null && TEXTPREVIEW != null)
        {
            InputFieldIn.onValueChanged.AddListener(UpdatePreviewText);

        }

    }

    private void UpdatePreviewText(string newText)
    {
        TEXTPREVIEW.text = newText;
    }

    void OnDestroy()
    {
        if (InputFieldIn != null)
        {
            InputFieldIn.onValueChanged.RemoveListener(UpdatePreviewText);
        }
    }
}


