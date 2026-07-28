using UnityEngine;

public class rotireLamaie : MonoBehaviour
{
    public GameObject storcatoare;
    public GameObject strainer;

    public int lamaiStoarse;
    public int kiwiStoarse;
    public int portocaleStoarse;

    private float totalRotation = 0f;
    private float lastAngle = 0f;

    public GameObject exit;
    AudioManeger audioManeger;

    private void Start()
    {
        Vector3 mousePos =Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction =  mousePos - storcatoare.transform.position;
        lastAngle =  Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        audioManeger = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManeger>();
    }
    private void Update()
    {
        if (!storcatoare.activeSelf)
            return;
        Vector3 mousePos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        Vector2 direction =  mousePos - storcatoare.transform.position;
        float angle =  Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        storcatoare.transform.localRotation = Quaternion.Euler(0f, 0f, angle);
        float deltaAngle = Mathf.DeltaAngle(lastAngle, angle);
        totalRotation += Mathf.Abs(deltaAngle);
        lastAngle = angle;
        if (totalRotation >= 2880f)
            FinishSqueezing();
    }
    private void FinishSqueezing()
    {
        audioManeger.SFX(audioManeger.stors);
        strainer strainerScript =  strainer.GetComponent<strainer>();
        umplutSauNu container =GameObject.Find("storcator").GetComponent<umplutSauNu>();

        float amount = strainerScript.cantitateSave;
        string fruit = strainerScript.fructActual;

        container.AdaugaFruct(fruit, amount);
        if (fruit == "Lemon")
            lamaiStoarse++;
        else if (fruit == "Kiwi")
            kiwiStoarse++;
        else if (fruit == "Orange")
            portocaleStoarse++;
        totalRotation = 0f;
        storcatoare.SetActive(false);
        strainerScript.mana.SetActive(true);
        if (container.umplut)
            exit.GetComponent<butonExitStrain>().iesireFortata();

    }
}