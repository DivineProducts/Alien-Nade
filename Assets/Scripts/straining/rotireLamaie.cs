using UnityEngine;

public class rotireLamaie : MonoBehaviour
{
    public GameObject storcatoare;
    public GameObject strainer;
    /*public GameObject storcator;*/
    public bool completedRotations = false;
    public float capacitate = 0;
    private float totalRotation = 0f;
    private float lastAngle = 0f;
    private void Start()
    {
        // de unde incep rotirile, ca sa nu trebuieasca sa resetam unghiul de fiecare data
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - storcatoare.transform.position;
        lastAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    }

    private void Update()
    {
        if (storcatoare.activeSelf )
        {  //astea rotesc
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0f;
            Vector2 direction = mousePos - storcatoare.transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            //astea tin cont de rotiri
            // trebuie local ca daca nu se rotesc tot si toate....
            storcatoare.transform.localRotation = Quaternion.Euler(0f, 0f, angle);
            float deltaAngle = Mathf.DeltaAngle(lastAngle, angle);
            totalRotation += Mathf.Abs(deltaAngle);
            lastAngle = angle;

            if (totalRotation >= 2880f)
            {
                capacitate += strainer.GetComponent<strainer>().cantitateSave;
                
                totalRotation = 0;
                lastAngle = 0;
                storcatoare.SetActive(false);
                strainer.GetComponent<strainer>().mana.SetActive(true);
                Debug.Log("8");
            }
        }
        if (capacitate >= 300)
        {
            GameObject.Find("storcator").transform.GetComponent<umplutSauNu>().umplut = true;
            
        }
    }
}
