using UnityEngine;
using UnityEngine.SceneManagement;
public class winer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        if (other.gameObject.name == "win")
        {
            SceneManager.LoadScene("ending");
        }
    }
}
