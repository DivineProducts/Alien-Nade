using UnityEngine;

public class stors : MonoBehaviour
{
    public GameObject mana;
    public GameObject copiiJumatati;
    public GameObject pozitieSpawn;

    public GameObject jumate;
    public GameObject jumateKiwi;
    public GameObject jumatePorto;
    private GameObject half;
    public int i;
    void Start()
    {
        mana = GameObject.FindGameObjectWithTag("tentaculR");
        mana.SetActive(false);
        copiiJumatati = GameObject.FindWithTag("jumLam");
        for (i=1; i <= GameObject.FindWithTag("jumLam").transform.childCount; i++)
            jumateSpawn();
        for (i = 1; i <= GameObject.FindWithTag("jumKiwi").transform.childCount; i++)
            jumateKiwiSpawn();
        for (i = 1; i <= GameObject.FindWithTag("jumPort").transform.childCount; i++)
            jumatePortSpawn();
    }
    private void jumateSpawn()
    {
        half = Instantiate(jumate, pozitieSpawn.transform.position, Quaternion.identity);
        Debug.Log(GameObject.FindWithTag("jumLam").transform.GetChild(i - 1).GetComponent<cantitate>().ml);
        half.GetComponent<cantitate>().ml = GameObject.FindWithTag("jumLam").transform.GetChild(i-1).GetComponent<cantitate>().ml;
        half.transform.parent=this.gameObject.transform;
    }
    private void jumateKiwiSpawn()
    {
        half = Instantiate(jumateKiwi, pozitieSpawn.transform.position, Quaternion.identity);
        Debug.Log(GameObject.FindWithTag("jumKiwi").transform.GetChild(i - 1).GetComponent<cantitate>().ml);
        half.GetComponent<cantitate>().ml = GameObject.FindWithTag("jumKiwi").transform.GetChild(i - 1).GetComponent<cantitate>().ml;
        half.transform.parent = this.gameObject.transform;
    }
    private void jumatePortSpawn()
    {
        half = Instantiate(jumatePorto, pozitieSpawn.transform.position, Quaternion.identity);
        Debug.Log(GameObject.FindWithTag("jumPort").transform.GetChild(i - 1).GetComponent<cantitate>().ml);
        half.GetComponent<cantitate>().ml = GameObject.FindWithTag("jumPort").transform.GetChild(i - 1).GetComponent<cantitate>().ml;
        half.transform.parent = this.gameObject.transform;
    }
}
