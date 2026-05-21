using UnityEngine;

public class strainer : MonoBehaviour
{
    public GameObject mana;
    public GameObject storcatoare;
    /*public GameObject storcator;*/
    private void OnTriggerEnter2D(Collider2D other)
    {
        /*Debug.Log("a atins");*/
        if (other.name == "LemonTaiatL(Clone)")
        {
            mana.SetActive(false);
            storcatoare.SetActive(true);
            /*storcator.SetActive(true);*/

            Debug.Log("a mers");
            /*float x = Mathf.PingPong(Time.time, 3f) + 10f;
                cutit.gameObject.transform.position = new Vector3(x, transform.position.y, transform.position.z);*/
            Destroy(other.gameObject);

        }
    }
}
