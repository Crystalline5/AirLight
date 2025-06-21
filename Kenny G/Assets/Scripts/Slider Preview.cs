using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderPreview : MonoBehaviour

{
    public Slider TheSlider;

    public TextMeshProUGUI Koko;

    void Start()
    {
        if (TheSlider != null && Koko != null)
        {
            TheSlider.onValueChanged.AddListener(UpdateRatingText);

            UpdateRatingText(TheSlider.value);

        }

    }

    private void UpdateRatingText(float value)
    {
        Koko.text = "Your Rating:" + value;
    }
    void OnDestroy()
    {
        if (TheSlider != null)
        {
            TheSlider.onValueChanged.RemoveListener(UpdateRatingText);
        }
    }
}
