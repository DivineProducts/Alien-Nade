using UnityEngine;

public class strainer : MonoBehaviour
{
    public GameObject mana;
    public GameObject storcatoare;
    public float cantitateSave;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        /*Debug.Log("a atins");*/
        if (other.name == "LemonTaiatLFx(Clone)")
        {
            mana.SetActive(false);
            storcatoare.SetActive(true);
            cantitateSave = other.GetComponent<cantitate>().ml;
            /*storcator.SetActive(true);*/

            Debug.Log("a mers");
            /*float x = Mathf.PingPong(Time.time, 3f) + 10f;
                cutit.gameObject.transform.position = new Vector3(x, transform.position.y, transform.position.z);*/
            Destroy(other.gameObject);
        }
        if (other.name == "KiwiTaiatLFx(Clone)")
        {
            mana.SetActive(false);
            storcatoare.SetActive(true);
            cantitateSave = other.GetComponent<cantitate>().ml;

            Destroy(other.gameObject);
        }
        if (other.name == "OrgTaiatLFx(Clone)")
        {
            mana.SetActive(false);
            storcatoare.SetActive(true);
            cantitateSave = other.GetComponent<cantitate>().ml;

            Destroy(other.gameObject);
        }
    }
}
