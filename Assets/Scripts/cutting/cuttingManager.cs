using UnityEngine;

public class cuttingManager : MonoBehaviour
{
    public GameObject mana;
    public GameObject copiiLamai;
    public GameObject pozitieSpawn;

    public GameObject lamaie;
    private GameObject lemon;
    void Start()
    {
        mana = GameObject.FindGameObjectWithTag("tentaculL");
        mana.SetActive(false);
        copiiLamai = GameObject.FindWithTag("tataLamaie");
        for (int i=1; i<= GameObject.FindWithTag("tataLamaie").transform.childCount; i++)
        {
            lamaieSpawn();
        }
    }
    private void lamaieSpawn()
    {
        lemon = Instantiate(lamaie, pozitieSpawn.transform.position, Quaternion.identity);
    }

}
