using UnityEngine;

public class cuttingBoard : MonoBehaviour
{
    public GameObject mana;
    public GameObject cutit;
    public GameObject cuttingLemon;
    public Sprite KiwiS;
    public Sprite LemonS;
    public Sprite OrangeS;
    private void OnTriggerEnter2D(Collider2D other)
    {
        /*Debug.Log("a atins");*/
        if (other.name == "LemonFx(Clone)")
        {
            mana.SetActive(false);
            cutit.SetActive(true);

            cuttingLemon.SetActive(true);
            cuttingLemon.GetComponent<SpriteRenderer>().sprite = LemonS;
            Debug.Log("a mers");
            /*float x = Mathf.PingPong(Time.time, 3f) + 10f;
                cutit.gameObject.transform.position = new Vector3(x, transform.position.y, transform.position.z);*/
            Destroy(other.gameObject);
        }
        if (other.name == "KiwiFx(Clone)")
        {
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
            mana.SetActive(false);
            cutit.SetActive(true);
            cuttingLemon.SetActive(true);
            cuttingLemon.GetComponent<SpriteRenderer>().sprite = OrangeS;
            Debug.Log("a mers");
            /*float x = Mathf.PingPong(Time.time, 3f) + 10f;
                cutit.gameObject.transform.position = new Vector3(x, transform.position.y, transform.position.z);*/
            Destroy(other.gameObject);
        }
    }
}
