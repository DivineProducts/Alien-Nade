using UnityEngine;

public class strainer : MonoBehaviour
{
    public GameObject mana;
    public GameObject storcatoare;

    public float cantitateSave;
    public string fructActual;

    private void OnTriggerEnter2D(Collider2D other)
    {
        umplutSauNu container = GameObject.Find("storcator")  .GetComponent<umplutSauNu>();
        string fruct = "";
        if (other.name == "LemonTaiatLFx(Clone)")
            fruct = "Lemon";
        else if (other.name == "KiwiTaiatLFx(Clone)")
            fruct = "Kiwi";
        else if (other.name == "OrgTaiatLFx 1(Clone)")
            fruct = "Orange";
        else
            return;
        if (!container.PoateStoarce(fruct))
            return;
        mana.SetActive(false);
        storcatoare.SetActive(true);
        cantitateSave = other.GetComponent<cantitate>().ml;
        fructActual = fruct;
        Destroy(other.gameObject);
    }
}
