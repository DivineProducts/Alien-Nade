using UnityEngine;

public class stors : MonoBehaviour
{
    public GameObject mana;
    public GameObject copiiJumatati;
    public GameObject pozitieSpawn;

    public GameObject jumate;
    private GameObject half;
    public int i;
    void Start()
    {
        mana = GameObject.FindGameObjectWithTag("tentaculR");
        mana.SetActive(false);
        copiiJumatati = GameObject.FindWithTag("tataJumatati");
        for (i=1; i <= GameObject.FindWithTag("tataJumatati").transform.childCount; i++)
            jumateSpawn();
    }
    private void jumateSpawn()
    {
        half = Instantiate(jumate, pozitieSpawn.transform.position, Quaternion.identity);
        Debug.Log(GameObject.FindWithTag("tataJumatati").transform.GetChild(i - 1).GetComponent<cantitate>().ml);
        half.GetComponent<cantitate>().ml = GameObject.FindWithTag("tataJumatati").transform.GetChild(i-1).GetComponent<cantitate>().ml;
        half.transform.parent=this.gameObject.transform;
    }
}
