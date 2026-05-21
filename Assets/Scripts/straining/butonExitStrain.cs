using UnityEngine;

public class butonExitStrain : MonoBehaviour
{
    public GameObject joc;
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
            for (int i = 0; i < joc.GetComponent<stors>().copiiJumatati.transform.childCount; i++)
                Destroy(joc.GetComponent<stors>().copiiJumatati.transform.GetChild(i).gameObject);
           
            Destroy(joc);
            joc.GetComponent<stors>().mana.SetActive(true);
        }

    }
}
