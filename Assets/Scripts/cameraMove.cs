using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public GameObject gameCamera;
    public GameObject endMarker;
    public void down()
    {
        gameCamera.transform.position = Vector3.Lerp(transform.position, endMarker.transform.position, Time.deltaTime);
    }

    public void up()
    {
        gameCamera.transform.position = Vector3.Lerp(transform.position, endMarker.transform.position, Time.deltaTime);
    }
}
