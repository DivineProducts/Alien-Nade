using UnityEngine;

public class movingStors : MonoBehaviour
{
    public GameObject strainer;
    public int cantitate = 0;
    public int nrjumatati = 0;
    void Start()
    {
        this.gameObject.GetComponent<Transform>().localPosition = new Vector3(13, 0, 0);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            nrjumatati++;
            /*v[nrlamai, 1] = (13 - wawa) * 100;
            v[nrlamai, 0] = (wawa - 10) * 100;*/
            strainer.GetComponent<cuttingBoard>().mana.SetActive(true);
            strainer.GetComponent<cuttingBoard>().cutit.SetActive(false);
            strainer.GetComponent<cuttingBoard>().cuttingLemon.SetActive(false);
        }
    }

}

