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
        mana.SetActive(false);
        for(int i=1; i<= copiiLamai.transform.childCount; i++)
        {
            lamaieSpawn();
        }
    }
    private void lamaieSpawn()
    {
        lemon = Instantiate(lamaie, pozitieSpawn.transform.position, Quaternion.identity);
    }

}
