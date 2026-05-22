using UnityEngine;

public class butonExit : MonoBehaviour
{
    public GameObject joc;
    public GameObject cutit;
    public GameObject half1;
    public GameObject half2;
    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.name == "base")
        {
            for (int i = 1; i <= cutit.GetComponent<moveing>().nrlamai && i <= joc.GetComponent<cuttingManager>().copiiLamai.transform.childCount; i++)
            {
                Debug.LogWarning(i);
                if (cutit.GetComponent<moveing>().v[i, 0] == 0)
                    break;
                Transform child = joc.GetComponent<cuttingManager>().copiiLamai.transform.GetChild(i - 1);
                Vector3 pos = child.position;
                GameObject h1 = Instantiate(half1, pos, Quaternion.identity);
                h1.GetComponent<cantitate>().ml = cutit.GetComponent<moveing>().v[i, 0] * 100;
                h1.GetComponent<Transform>().SetParent(GameObject.FindGameObjectWithTag("tataJumatati").transform);
                GameObject h2 = Instantiate(half2, pos, Quaternion.identity);
                h2.GetComponent<cantitate>().ml = cutit.GetComponent<moveing>().v[i, 1] * 100;
                h2.GetComponent<Transform>().SetParent(GameObject.FindGameObjectWithTag("tataJumatati").transform);

            }
            for (int i = 0;  i < joc.GetComponent<cuttingManager>().copiiLamai.transform.childCount; i++)
                Destroy(joc.GetComponent<cuttingManager>().copiiLamai.transform.GetChild(i).gameObject);
            /*int i = 1;
            while (joc.GetComponent<cuttingManager>().copiiLamai.transform.childCount > 0)
            {
                Debug.LogWarning(i);
                if (cutit.GetComponent<moveing>().v[i, 0] == 0)
                    break;
                Transform child = joc.GetComponent<cuttingManager>().copiiLamai.transform.GetChild(1);
                Vector3 pos = child.position;
                GameObject h1 = Instantiate(half1, pos, Quaternion.identity);
                h1.GetComponent<cantitate>().ml = cutit.GetComponent<moveing>().v[i, 0] * 100;

                GameObject h2 = Instantiate(half2, pos, Quaternion.identity);
                h2.GetComponent<cantitate>().ml = cutit.GetComponent<moveing>().v[i, 1] * 100;

                Destroy(child.gameObject);
                i++;
            }*/
            Destroy(joc);
            joc.GetComponent<cuttingManager>().mana.SetActive(true);
        }
        
        }
    }
