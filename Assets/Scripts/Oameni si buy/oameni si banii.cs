using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Unity.Collections;

public class oamenisibanii : MonoBehaviour
{
    public GameObject comandalol;
    public bool Item1=false;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Numar2;
    public GameObject Numar3;

    public Sprite om1;
    public Sprite om2;
    public Sprite om3;
    public Sprite om4;
    public Sprite om5;
    public Sprite om6;

    public Sprite nr1;
    public Sprite nr2;
    public Sprite nr3;

    public GameObject bara;
    private float priCre= 1/3f;

    private bool SusJos = true;

    private bool ComandaInProcesare=false;
    /* public Sprite gheata;
     public Sprite zahar;*/

    private int ranOM;

    private int rndcatez;
    private int rndcateg;

    private int rndesteG;
    private int rndesteZ;

    private float wawa = 50f;

    private float timerig = 60f;
    private bool SopTimer = false;
    private Coroutine cevacutimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RandomizareComanda();
        RandomizareOm();
    }

    // Update is called once per frame
    void Update()
    {
        /* this.gameObject.GetComponent<Transform>().localPosition += new Vector3(wawa * 1/5 * Time.deltaTime, 0, 0);
 */
        Miscare();
        /*if (this.gameObject.GetComponent<Transform>().localPosition.x >= 13f)
        {
            this.gameObject.GetComponent<Transform>().localPosition -= new Vector3(2 * this.gameObject.GetComponent<Transform>().localPosition.x, 0, 0);
        }
*/
    }

    public void RandomizareOm()
    {
        ranOM = UnityEngine.Random.Range(1, 13);
        if (ranOM == 1 || ranOM == 9) { this.GetComponent<SpriteRenderer>().sprite = om1; }
        if (ranOM == 2 || ranOM == 7) { this.GetComponent<SpriteRenderer>().sprite = om2; }
        if (ranOM == 3 || ranOM == 10) { this.GetComponent<SpriteRenderer>().sprite = om3; }
        if (ranOM == 4 || ranOM == 11) { this.GetComponent<SpriteRenderer>().sprite = om4; }
        if (ranOM == 5 || ranOM == 8) { this.GetComponent<SpriteRenderer>().sprite = om5; }
        if (ranOM == 6 || ranOM == 12) { this.GetComponent<SpriteRenderer>().sprite = om6; }

    }
    public void RandomizareComanda()
    {
        Item1 = false;
        Item3.SetActive(true);
        Item2.SetActive(true);
        /* rndcateg = UnityEngine.Random.Range(0, 3);
         rndcatez = UnityEngine.Random.Range(0, 3);*/
        rndesteZ = UnityEngine.Random.Range(0, 4);
        rndesteG = UnityEngine.Random.Range(0, 4);

        if (rndesteG == 0) { 
            rndcateg = 0; 
            Item3.SetActive(false);
        }
        else { 
            rndcateg = UnityEngine.Random.Range(1, 3);
            if (rndcateg == 1) { Numar3.gameObject.GetComponent<SpriteRenderer>().sprite = nr1; }
            if (rndcateg == 2) { Numar3.gameObject.GetComponent<SpriteRenderer>().sprite = nr2; }
            if (rndcateg == 3) { Numar3.gameObject.GetComponent<SpriteRenderer>().sprite = nr3; }
        }

        if (rndesteZ == 0) {
            rndcatez = 0;
            Item2.SetActive(false);
        }
        else { 
            rndcatez = UnityEngine.Random.Range(1, 3);
            if (rndcatez == 1) { Numar2.gameObject.GetComponent<SpriteRenderer>().sprite = nr1; }
            if (rndcatez == 2) { Numar2.gameObject.GetComponent<SpriteRenderer>().sprite = nr2; }
            if (rndcatez == 3) { Numar2.gameObject.GetComponent<SpriteRenderer>().sprite = nr3; }
        }

        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.TryGetComponent<BehaviourOfPahare>(out BehaviourOfPahare scriptpahah))
        {
            if (other.GetComponent<BehaviourOfPahare>().CntGheataP == rndcateg && other.GetComponent<BehaviourOfPahare>().CntZaharP == rndcatez && Item1==true)
            {
                Debug.Log("Comanada e buna");
                RandomizareComanda();
                Destroy(other.gameObject);
                ComandaInProcesare = false;
                timerig = 60f;

               /* bara.transform.localScale = new Vector3(bara.transform.localScale.x, bara.transform.localScale.y + priCre, bara.transform.localScale.z);*/

                StartCoroutine(GrowBar(priCre, 0.5f));
            }
            else
            {
                Debug.Log("Comanada e gresita");
                RandomizareComanda(); 
                Destroy(other.gameObject);
                ComandaInProcesare = false;
                timerig = 60f;
            }
            
        }
        

    }

    IEnumerator GrowBar(float amount, float duration)
    {
        Vector3 initial = bara.transform.localScale;
        Vector3 targetScale = new Vector3(initial.x, initial.y + amount, initial.z);
        Vector3 initialpoz = bara.transform.position;
        Vector3 targetPos = initialpoz + new Vector3(0, amount*1.5f, 0);
        float time = 0f;
        while (time < duration)
        {
            time += Time.deltaTime;
            bara.transform.localScale =Vector3.Lerp(initial, targetScale, time / duration);
            bara.transform.position =Vector3.Lerp(initialpoz, targetPos, time / duration);

            yield return null;
        }

        bara.transform.localScale = targetScale;
        bara.transform.position = targetPos;
    }
    public void Miscare()
    {
        if (this.gameObject.GetComponent<Transform>().localPosition.x <= 0f)
        {
            if (SusJos)
            {
                this.gameObject.GetComponent<Transform>().localPosition += new Vector3(wawa * 1 / 5 * Time.deltaTime, wawa * 1 / 10 * Time.deltaTime, 0);
                SusJos= false;
            }
            else
            {
                this.gameObject.GetComponent<Transform>().localPosition += new Vector3(wawa * 1 / 5 * Time.deltaTime, 0, 0);
                this.gameObject.GetComponent<Transform>().localPosition -= new Vector3(0, wawa * 1 / 10 * Time.deltaTime, 0);
                SusJos = true;
            }
        }
        if (this.gameObject.GetComponent<Transform>().localPosition.x <= 0f && this.gameObject.GetComponent<Transform>().localPosition.x>=-0.7)
        { 
            comandalol.SetActive(true);
            ComandaInProcesare = true;
            StartTig();
        }
        if (SopTimer == true && ComandaInProcesare == true)
        {
            
            ComandaInProcesare = false;
        }
        if (ComandaInProcesare == false )
        {
            comandalol.SetActive(false);
            if (this.gameObject.GetComponent<Transform>().localPosition.x <= 13f)
            {
                if (SusJos)
                {
                    this.gameObject.GetComponent<Transform>().localPosition += new Vector3(wawa * 1 / 5 * Time.deltaTime, wawa * 1 / 10 * Time.deltaTime, 0);
                    SusJos = false;
                }
                else
                {
                    this.gameObject.GetComponent<Transform>().localPosition += new Vector3(wawa * 1 / 5 * Time.deltaTime, 0, 0);
                    this.gameObject.GetComponent<Transform>().localPosition -= new Vector3(0, wawa * 1 / 10 * Time.deltaTime, 0);
                    SusJos = true;
                }
            }
            else 
            {
                this.gameObject.GetComponent<Transform>().localPosition -= new Vector3(2 * this.gameObject.GetComponent<Transform>().localPosition.x, 0, 0);
                this.gameObject.GetComponent<Transform>().localPosition = new Vector3(this.gameObject.GetComponent<Transform>().localPosition.x, 1.67f, 0);
                RandomizareOm();

            }
        }


    }

    public void StartTig()
    {
        if(cevacutimer == null)
        {
            timerig = 60;
            SopTimer = false; 
            cevacutimer = StartCoroutine(CatTimpp());
        }
    }
   private IEnumerator CatTimpp()
    {
        while (timerig > 0)
        {
            yield return new WaitForSeconds(1f);
            timerig--;
            /*Debug.Log(timerig);*/
        }

        cevacutimer = null;  
       SopTimer = true;
        Debug.Log(SopTimer);

    }

}
