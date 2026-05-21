using UnityEngine;

public class rotireLamaie : MonoBehaviour
{
    public GameObject storcatoare;
    public GameObject strainer;
    /*public GameObject storcator;*/
    public bool completedRotations = false;
    public int lamaiStoarse;
    private float totalRotation = 0f;
    private float lastAngle = 0f;
    public GameObject exit;
    private void Start()
    {
        // de unde incep rotirile, ca sa nu trebuieasca sa resetam unghiul de fiecare data
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - storcatoare.transform.position;
        lastAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    }

    private void Update()
    {
        if (storcatoare.activeSelf)
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
                GameObject.Find("storcator").transform.GetComponent<umplutSauNu>().capacitate += strainer.GetComponent<strainer>().cantitateSave;

                lamaiStoarse++;
                totalRotation = 0;
                lastAngle = 0;
                storcatoare.SetActive(false);
                strainer.GetComponent<strainer>().mana.SetActive(true);
                Debug.Log("8");
            }
        }
        if (GameObject.Find("storcator").transform.GetComponent<umplutSauNu>().capacitate >= 300)
        {
            exit.gameObject.transform.GetComponent<butonExitStrain>().iesireFortata();
            GameObject.Find("storcator").transform.GetComponent<umplutSauNu>().umplut = true;
            
        }
    }
}
