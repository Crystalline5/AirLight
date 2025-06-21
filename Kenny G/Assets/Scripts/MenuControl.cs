using UnityEngine;

public class MenuControl : MonoBehaviour
{
   public GameObject Pause;

   public GameObject Guzik;

   public void TogglePause()

   {
       bool isCurrentlyActive = Pause.activeSelf;



     Pause.SetActive(!isCurrentlyActive);

     Guzik.SetActive(isCurrentlyActive);




    }
}
