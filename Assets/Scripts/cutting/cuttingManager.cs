using UnityEngine;

public class cuttingManager : MonoBehaviour
{
    public GameObject mana;
    public GameObject copiiLamai;
    public GameObject pozitieSpawn;

    public GameObject lamaie;
    public GameObject kiwiRom;
    public GameObject portocala;

    private GameObject lemon;
    private GameObject kiwi;
    private GameObject orange;
    void Start()
    {
        mana = GameObject.FindGameObjectWithTag("tentaculL");
        mana.SetActive(false);
        copiiLamai = GameObject.FindWithTag("tataLamaie");
        for (int i=1; i<= GameObject.FindWithTag("tataLamaie").transform.childCount; i++)
        {if(GameObject.FindWithTag("tataLamaie").transform.GetChild(i - 1).name == "Lemon(Clone)")
            lamaieSpawn();
            if (GameObject.FindWithTag("tataLamaie").transform.GetChild(i - 1).name == "Kiwi(Clone)")
                kiwiRomSpawn();
            if (GameObject.FindWithTag("tataLamaie").transform.GetChild(i - 1).name == "Orange(Clone)")
                portocalaSpawn();
        }
    }
    private void lamaieSpawn()
    {
        lemon = Instantiate(lamaie, pozitieSpawn.transform.position, Quaternion.identity);
    }
    private void kiwiRomSpawn()
    {
        kiwi = Instantiate(kiwiRom, pozitieSpawn.transform.position, Quaternion.identity);
    }
    private void portocalaSpawn()
    {
        orange = Instantiate(portocala, pozitieSpawn.transform.position, Quaternion.identity);
    }
}
