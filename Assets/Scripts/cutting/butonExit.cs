using UnityEngine;

public class butonExit : MonoBehaviour
{
    public GameObject joc;
    public GameObject cutit;
    
    public GameObject half1;
    public GameObject half2;

    public GameObject halfKiwi1;
    public GameObject halfKiwi2;

    public GameObject halfPorto11;
    public GameObject halfPorto12;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name != "base")
            return;
        cuttingManager manager = joc.GetComponent<cuttingManager>();
        cuttingBoard board = joc.GetComponentInChildren<cuttingBoard>();
        moveing moving = cutit.GetComponent<moveing>();

        for (int i = 1; i <= moving.nrlamai; i++)
        {
            Transform child =manager.copiiLamai.transform.GetChild(i - 1);
            Vector3 pos = child.position;
            GameObject h1 =Instantiate(half1, pos, Quaternion.identity);
            h1.GetComponent<cantitate>().ml = moving.v[i, 0] * 100;
            h1.transform.SetParent(GameObject.FindGameObjectWithTag("jumLam").transform);
            GameObject h2 = Instantiate(half2, pos, Quaternion.identity);
            h2.GetComponent<cantitate>().ml =moving.v[i, 1] * 100;
            h2.transform.SetParent(GameObject.FindGameObjectWithTag("jumLam").transform);
        }
        for (int i = moving.nrlamai - 1; i >= 0; i--)
        {
            Destroy(manager.copiiLamai.transform.GetChild(i).gameObject);
        }

        for (int i = 1; i <= moving.nrkiwi; i++)
        {
            Transform child = manager.copiiKiwi.transform.GetChild(i - 1);
            Vector3 pos = child.position;
            GameObject h1 =  Instantiate(halfKiwi1, pos, Quaternion.identity);
            h1.GetComponent<cantitate>().ml = moving.k[i, 0] * 100;
            h1.transform.SetParent(GameObject.FindGameObjectWithTag("jumKiwi").transform);
            GameObject h2 = Instantiate(halfKiwi2, pos, Quaternion.identity);
            h2.GetComponent<cantitate>().ml = moving.k[i, 1] * 100;
            h2.transform.SetParent(GameObject.FindGameObjectWithTag("jumKiwi").transform);
        }

        for (int i = moving.nrkiwi - 1; i >= 0; i--)
        {
            Destroy(manager.copiiKiwi.transform.GetChild(i).gameObject);
        }
        for (int i = 1; i <= moving.nrporto; i++)
        {
            Transform child = manager.copiiPortocale.transform.GetChild(i - 1);
              Vector3 pos = child.position;
            GameObject h1 =Instantiate(halfPorto11, pos, Quaternion.identity);
            h1.GetComponent<cantitate>().ml =moving.p[i, 0] * 100;
            h1.transform.SetParent(GameObject.FindGameObjectWithTag("jumPort").transform);
            GameObject h2 = Instantiate(halfPorto12, pos, Quaternion.identity);
            h2.GetComponent<cantitate>().ml =  moving.p[i, 1] * 100;
            h2.transform.SetParent(GameObject.FindGameObjectWithTag("jumPort").transform);
        }
        for (int i = moving.nrporto - 1; i >= 0; i--)
        {
            Destroy(manager.copiiPortocale.transform.GetChild(i).gameObject);
        }
        joc.GetComponent<cuttingManager>().mana.SetActive(true);
        Destroy(joc);
    }
}
