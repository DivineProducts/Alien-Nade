using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public GameObject gameCamera;
    public GameObject endMarker;
    public GameObject startMarker;
    public void down()
    {
        gameCamera.transform.position = Vector3.Lerp(transform.position, endMarker.transform.position, /*Time.deltaTime*/5.0f);
        
    }
    public void up()
    {
        gameCamera.transform.position = Vector3.Lerp(transform.position, startMarker.transform.position, 5.0f);
    }
    public void move()
    {
        if(gameCamera.transform.position == startMarker.transform.position)
           gameCamera.transform.position = Vector3.Lerp(transform.position, endMarker.transform.position, 5.0f);
        else 
            gameCamera.transform.position = Vector3.Lerp(transform.position, startMarker.transform.position, 5.0f);
    }
}
