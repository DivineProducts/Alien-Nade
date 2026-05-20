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
            for (int i = 1; i <= cutit.GetComponent<moveing>().nrlamai && i < joc.GetComponent<cuttingManager>().copiiLamai.transform.childCount; i++)
            {
                if (cutit.GetComponent<moveing>().v[i, 0] == 0)
                    break;
                Transform child = joc.GetComponent<cuttingManager>().copiiLamai.transform.GetChild(i);
                Vector3 pos = child.position;
                GameObject h1 = Instantiate(half1, pos, Quaternion.identity);
                h1.GetComponent<cantitate>().ml = cutit.GetComponent<moveing>().v[i, 0] * 100;

                GameObject h2 = Instantiate(half2, pos, Quaternion.identity);
                h2.GetComponent<cantitate>().ml = cutit.GetComponent<moveing>().v[i, 1] * 100;

                Destroy(child.gameObject);
            }
            Destroy(joc);
            joc.GetComponent<cuttingManager>().mana.SetActive(true);
            /*// optional cleanup
            Destroy(joc);
            *//*if (Input.GetKeyUp(KeyCode.Z))
            {*//*
            
            foreach (Transform child in joc.GetComponent<cuttingManager>().copiiLamai.transform)
            {
                Vector3 pos = child.position;
                Instantiate(half1, pos, Quaternion.identity);
                half1.GetComponent<cantitate>().ml = cutit.GetComponent<moveing>().v[*//*cutit.GetComponent<moveing>().nrlamai*//* i, 0] * 100;
                Instantiate(half2, pos, Quaternion.identity);
                half2.GetComponent<cantitate>().ml = cutit.GetComponent<moveing>().v[i, 1] * 100;
                Destroy(child.gameObject);
                *//* }*//*
                if (i > cutit.GetComponent<moveing>().nrlamai)
                {
                    Destroy(child.gameObject);
                    Destroy(joc);
                    break;
                }
                i++;*/
        }
            
        }
    }
