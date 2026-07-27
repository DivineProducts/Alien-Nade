using UnityEngine;

public class butonExitStrain : MonoBehaviour
{
    public GameObject joc;
    public GameObject lamaieRotita;
    public GameObject manaStoarce;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "base")
        {
            /*for (int i = 1; i <= manaStoarce.GetComponent<movingStors>().nrjumatati && i <= joc.GetComponent<stors>().copiiJumatati.transform.childCount; i++)
            {
              *//*  if (manaStoarce.GetComponent<movingStors>() == 0)
                    break;*//*
                Transform child = joc.GetComponent<cuttingManager>().copiiLamai.transform.GetChild(1);
                Vector3 pos = child.position;
            }*/
            for (int i = 0; i < lamaieRotita.GetComponent<rotireLamaie>().lamaiStoarse; i++)
                Destroy(GameObject.FindWithTag("jumLam").transform.GetChild(i).gameObject);
            for (int i = 0; i < lamaieRotita.GetComponent<rotireLamaie>().portocaleStoarse; i++)
                Destroy(GameObject.FindWithTag("jumPort").transform.GetChild(i).gameObject);
            for (int i = 0; i < lamaieRotita.GetComponent<rotireLamaie>().kiwiStoarse; i++)
                Destroy(GameObject.FindWithTag("jumKiwi").transform.GetChild(i).gameObject);
            Destroy(joc);
            joc.GetComponent<stors>().mana.SetActive(true);
        }
    }
    public void iesireFortata()
    {
        for (int i = 0; i < lamaieRotita.GetComponent<rotireLamaie>().lamaiStoarse; i++)
            Destroy(GameObject.FindWithTag("jumLam").transform.GetChild(i).gameObject);
        for (int i = 0; i < lamaieRotita.GetComponent<rotireLamaie>().portocaleStoarse; i++)
            Destroy(GameObject.FindWithTag("jumPort").transform.GetChild(i).gameObject);
        for (int i = 0; i < lamaieRotita.GetComponent<rotireLamaie>().kiwiStoarse; i++)
            Destroy(GameObject.FindWithTag("jumKiwi").transform.GetChild(i).gameObject);
        Destroy(joc);
        joc.GetComponent<stors>().mana.SetActive(true);
    }
}
