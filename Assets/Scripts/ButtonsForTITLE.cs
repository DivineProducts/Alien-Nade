using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonsForTITLE : MonoBehaviour
{
   public GameObject TextWok;
   public  IEnumerator WaitAndLog()
    {
        yield return new WaitForSeconds(2f);
        TextWok.SetActive(false);
    }
    public void ExitButn()
    {
        Application.Quit();
    }

    public void OptionsBtn()
    {
       TextWok.SetActive(true);
        StartCoroutine(WaitAndLog());
        
    }

    public void StartJocBtn()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ContinueBtn()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
