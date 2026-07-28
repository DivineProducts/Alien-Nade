using UnityEngine;

public class managingScript : MonoBehaviour
{
    public GameObject manaDreapta;
    public GameObject manaStanga;
    public GameObject telefon;

    public void verifyMinigame()
    {
        if (manaDreapta.GetComponent<tacleMove>().tine)
        {

        }
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {if (telefon.activeSelf)
            {
                telefon.SetActive(false);
               
            }
            else telefon.SetActive(true);
        }
    }
}
