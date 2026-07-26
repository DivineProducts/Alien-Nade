using UnityEngine;

public class moveing : MonoBehaviour
{
    public GameObject board;
    public float[,] v = new float[200, 2];
    public int nrlamai = 0;
    public float[,] k = new float[200, 2];
    public int nrkiwi = 0;
    public float[,] p = new float[200, 2];
    public int nrporto = 0;

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
            float left = Mathf.Round(
                   (transform.localPosition.x - 10f) * 100f) / 100f;
            float right = Mathf.Round(
                (13f - transform.localPosition.x) * 100f) / 100f;

            if (board.GetComponent<cuttingBoard>().numeFructActual == "LemonFx(Clone)")
            {
                nrlamai++;

                v[nrlamai, 0] = left;
                v[nrlamai, 1] = right;
            }
            else if (board.GetComponent<cuttingBoard>().numeFructActual == "KiwiFx(Clone)")
            {
                nrkiwi++;

                k[nrkiwi, 0] = left;
                k[nrkiwi, 1] = right;
            }
            else if (board.GetComponent<cuttingBoard>().numeFructActual == "OrangeFx(Clone)")
            {
                nrporto++;

                p[nrporto, 0] = left;
                p[nrporto, 1] = right;
            }
            Debug.Log(v[nrlamai, 0]);
            board.GetComponent<cuttingBoard>().mana.SetActive(true);
            board.GetComponent<cuttingBoard>().cutit.SetActive(false);
            board.GetComponent<cuttingBoard>().cuttingLemon.SetActive(false);
        }
    }
    
}
