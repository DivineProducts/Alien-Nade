using UnityEngine;

public class moveing : MonoBehaviour
{
    public GameObject board;
    public float[,] v = new float[200, 2];
    public int nrlamai = 0;
    private float wawa=50f;
    void Start()
    {
        this.gameObject.GetComponent<Transform>().localPosition = new Vector3(13, 0, 0);
    }

        void Update()
        {
        this.gameObject.GetComponent<Transform>().localPosition += new Vector3(wawa*7* Time.deltaTime, 0, 0);

            if (this.gameObject.GetComponent<Transform>().localPosition.x >= 13f)
            {
            wawa = -1f;
            }

            if (this.gameObject.GetComponent<Transform>().localPosition.x <= 10f)
            {
            wawa = 1f;
            }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            nrlamai++;
            /*v[nrlamai, 1] = (13 - wawa) * 100;
            v[nrlamai, 0] = (wawa - 10) * 100;*/
            v[nrlamai, 0] = Mathf.Round((transform.localPosition.x - 10f) * 100f) / 100f;
            v[nrlamai, 1] = Mathf.Round((13f - transform.localPosition.x) * 100f) / 100f;
            Debug.Log(v[nrlamai, 0]);
            board.GetComponent<cuttingBoard>().mana.SetActive(true);
            board.GetComponent<cuttingBoard>().cutit.SetActive(false);
            board.GetComponent<cuttingBoard>().cuttingLemon.SetActive(false);
        }
    }
    
}
