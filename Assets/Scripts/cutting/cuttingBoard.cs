using UnityEngine;

public class cuttingBoard : MonoBehaviour
{
    public GameObject mana;
    public GameObject cutit;
    public GameObject cuttingLemon;
    public int ltaiate = 0;
    public int ptaiate = 0;
    public int ktaiate = 0;
    public Sprite KiwiS;
    public Sprite LemonS;
    public Sprite OrangeS;

    public string numeFructActual;
    private void OnTriggerEnter2D(Collider2D other)
    {
        /*Debug.Log("a atins");*/
        if (other.name == "LemonFx(Clone)")
        {
            ltaiate++;

            mana.SetActive(false);
            cutit.SetActive(true);

            cuttingLemon.SetActive(true);
            cuttingLemon.GetComponent<SpriteRenderer>().sprite = LemonS;
            /*float x = Mathf.PingPong(Time.time, 3f) + 10f;
                cutit.gameObject.transform.position = new Vector3(x, transform.position.y, transform.position.z);*/
            Destroy(other.gameObject);
        }
        if (other.name == "KiwiFx(Clone)")
        {
            ktaiate++;

            mana.SetActive(false);
            cutit.SetActive(true);
            cuttingLemon.SetActive(true);
            cuttingLemon.GetComponent<SpriteRenderer>().sprite = KiwiS;
            Debug.Log("a mers");
            /*float x = Mathf.PingPong(Time.time, 3f) + 10f;
                cutit.gameObject.transform.position = new Vector3(x, transform.position.y, transform.position.z);*/
            Destroy(other.gameObject);
        }
        if (other.name == "OrangeFx(Clone)")
        {
            ptaiate++;

            mana.SetActive(false);
            cutit.SetActive(true);
            cuttingLemon.SetActive(true);
            cuttingLemon.GetComponent<SpriteRenderer>().sprite = OrangeS;
            Debug.Log("a mers");
            /*float x = Mathf.PingPong(Time.time, 3f) + 10f;
                cutit.gameObject.transform.position = new Vector3(x, transform.position.y, transform.position.z);*/
            Destroy(other.gameObject);
        }
        numeFructActual = other.name;
    }
}
