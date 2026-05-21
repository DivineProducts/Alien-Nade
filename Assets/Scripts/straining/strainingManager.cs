using UnityEngine;

public class stors : MonoBehaviour
{
    public GameObject mana;
    public GameObject copiiJumatati;
    public GameObject pozitieSpawn;

    public GameObject jumate;
    private GameObject half;
    void Start()
    {
        mana = GameObject.FindGameObjectWithTag("tentaculR");
        mana.SetActive(false);
        copiiJumatati = GameObject.FindWithTag("tataJumatati");
        for (int i = 1; i <= GameObject.FindWithTag("tataJumatati").transform.childCount; i++)
            jumateSpawn();
    }
    private void jumateSpawn()
    {
        half = Instantiate(jumate, pozitieSpawn.transform.position, Quaternion.identity);
    }
}
