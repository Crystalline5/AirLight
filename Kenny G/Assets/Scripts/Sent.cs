using UnityEngine;
using TMPro;
using System.Collections;

public class Sent : MonoBehaviour
{
    public TextMeshProUGUI SentScreen;

    public GameObject Feedback;

    public float displayDuration = 2f;

    public void ShowNotification()
    {
        StartCoroutine(ShowAndHideNotificationRoutine());
    }



    private IEnumerator ShowAndHideNotificationRoutine()

    {
        Feedback.SetActive(false);

        SentScreen.gameObject.SetActive(true);

        yield return new WaitForSeconds(displayDuration);

        SentScreen.gameObject.SetActive(false);

        Feedback.SetActive(true);


    }


}

