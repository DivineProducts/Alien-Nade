using Unity.VisualScripting;
using UnityEngine;

public class tacleMove : MonoBehaviour
{
    public Sprite curved;
    public Sprite straight;
    public float followSpeed = 15f;
    private Vector3 distObMous;
    private bool urmareste = false;
    private bool stop = false;
    public GameObject lamai;

    //grabbing stuff
    private GameObject grabbedOb;
    private GameObject grabbedPahar;
    private GameObject grabbedLamaie;
    private GameObject grabbedZahar;
    private GameObject grabbedGheata;
    public bool tine = false;

    private GameObject butonDown;
    private GameObject butonUp;
    //prfabs
    private GameObject cup;
    public GameObject pahar;
    public GameObject lamaie;
    private GameObject lemon;
    public GameObject zahar;
    private GameObject sugar;
    public GameObject gheata;
    private GameObject ice;
    public GameObject cutMiniGame;


    //telefon
    public GameObject phone;
    public GameObject Butoane;
    public GameObject Xmark;
    public GameObject Backb;
    public GameObject Marketb;
    public GameObject Settingsb;
    public GameObject Exitb;

    //market
    public GameObject BuyLemon;
    public GameObject BuySugar;
    public GameObject BuyCups;
    public GameObject BuyIce;
    public GameObject SXmark;

    void Update()
    {   // doar il face sa devina inapoi dynamic ;  restul se reactiveaza de la sine
        if (Input.GetKeyUp(KeyCode.Z))
        {
            if (grabbedOb != null)
            {
               if( grabbedOb.name== "cuttingBoard")
                    Instantiate(cutMiniGame, new Vector3(-15.8900003f, -2.70000005f, -0.100787707f), Quaternion.identity);
                grabbedOb.GetComponent<BoxCollider2D>().isTrigger = false;
            }
            if (tine)
            {
                // da drumul
                /* grabbedOb.transform.parent = null;*/
                tine = false;
            }
            this.GetComponent<SpriteRenderer>().sprite = straight;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }

        //  transforma obiectul intrunul static
        if (Input.GetKeyDown(KeyCode.A))
        {
            urmareste = false;
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            GetComponent<Rigidbody2D>().angularVelocity = 0f;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.GetComponent<SpriteRenderer>().sprite = curved;
            /*urmareste = false;
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            GetComponent<Rigidbody2D>().angularVelocity = 0f;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;*/
            if (grabbedOb != null)
            {
                // Grab the object
               /* grabbedOb.transform.parent = transform;*/
                tine = true;
            }
            if (grabbedPahar != null)
            {
                tine = true;
                paharSpawn();
                grabbedOb = cup;
                grabbedPahar.GetComponent<pahareControl>().schimbaSprite();
            }
            if(grabbedLamaie != null)
            {
                tine = true;
                lamaieSpawn();
                grabbedOb = lemon;
                grabbedLamaie.GetComponent<lamaiControl>().schimbaSprite();
            }
            if (grabbedZahar != null)
            {
                tine = true;
                zaharSpawn();
                grabbedOb = sugar;
                grabbedZahar.GetComponent<zaharControl>().schimbaSprite();
            }
            if (grabbedGheata != null)
            {
                tine = true;
                gheataSpawn();
                grabbedOb = ice;
                grabbedGheata.GetComponent<gheataControl>().schimbaSprite();
            }
            if (butonDown != null)
            {
                butonDown.GetComponent<cameraMove>().move();
                butonDown = null;
            }
            if (butonUp != null)
            {
                /*Debug.Log("merge");*/
                butonUp.GetComponent<cameraMove>().move();
                butonUp = null;
            }
            if(Backb!=null)
            {
                Backb = null;
            }
            if(Marketb!=null)
            {
                Marketb.GetComponent<Telefon>().DeschideMarket();
                Marketb = null;
            }
            if(Settingsb!=null)
            {

                Settingsb = null;
            }
            if(Exitb!=null)
            {
                Application.Quit();
            }
            if (BuyLemon != null)
            {
                BuyLemon.GetComponent<Telefon>().BuyL();
                BuyLemon = null;
            }
            if (BuyCups != null)
            {
                BuyCups.GetComponent<Telefon>().BuyC();
                BuyCups = null;
            }
            if (BuySugar != null)
            {
                BuySugar.GetComponent<Telefon>().BuyZ();
                BuySugar = null;
            }
            if (BuyIce != null)
            {
                BuyIce.GetComponent<Telefon>().BuyI();
                BuyIce = null;
            }
            if(SXmark != null)
            {
                SXmark.GetComponent<Telefon>().InchideMarket();
                SXmark = null;
            }

        }

        // uff, 0=LeftMouse; 1=RightMouse.... bagamias piciarele
        if (Input.GetMouseButtonDown(0) && !stop)
        {
            urmareste = true;
            //Vector3???
            Vector2 mouseReal = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Vector2 mous2d = mouseReal;
            distObMous = GetComponent<Rigidbody2D>().position - mouseReal;
        }
    else 
        if (Input.GetMouseButtonUp(0))
        {
            urmareste = false;
        }
    }
    void FixedUpdate()
    {
        if (urmareste==true && stop==false)
        {
            Vector3 mouseReal2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 targetPos = mouseReal2 + distObMous;
            GetComponent<Rigidbody2D>().MovePosition(Vector2.Lerp(GetComponent<Rigidbody2D>().position, targetPos, followSpeed * Time.fixedDeltaTime));
        }
        if (tine == true)
        {
            if (grabbedOb != null)
            {
                if (grabbedOb.GetComponent<BoxCollider2D>().isTrigger == false)
                    grabbedOb.GetComponent<BoxCollider2D>().isTrigger = true;

                Vector3 mouseReal2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 targetPos = mouseReal2 + distObMous;
                grabbedOb.GetComponent<Rigidbody2D>().MovePosition(Vector2.Lerp(GetComponent<Rigidbody2D>().position, targetPos, followSpeed * Time.fixedDeltaTime));

            }
        }

    }

    //Grabbing stuff
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!tine)
        {
            if (other.gameObject.CompareTag("Grabbable"))
            {
                grabbedOb = other.gameObject;
            }
            if (other.gameObject.CompareTag("ScoatePahar"))
            {
                if (other.gameObject.GetComponent<pahareControl>().pahareRamase > 0)
                    grabbedPahar = other.gameObject;
            }
            if (other.gameObject.CompareTag("ScoateLamaie"))
            {
                if (other.gameObject.GetComponent<lamaiControl>().lamaiRamase > 0)
                grabbedLamaie = other.gameObject;
            }
            if (other.gameObject.CompareTag("ScoateZahar") && other.GetComponent<zaharControl>().zaharRamase !=0 )
            {
                if (other.gameObject.GetComponent<zaharControl>().zaharRamase > 0)
                grabbedZahar = other.gameObject;
            }
            if (other.gameObject.CompareTag("ScoateGheata"))
            {
                if(other.gameObject.GetComponent<gheataControl>().gheataRamasa > 0)
                grabbedGheata = other.gameObject;
            }
            if (other.gameObject.CompareTag("down"))
            {
                butonDown = other.gameObject;
            }
            if (other.gameObject.CompareTag("up"))
            {
                butonUp = other.gameObject;
            }
            if(other.gameObject.CompareTag("backAPP"))
            {
                Backb = other.gameObject;
            }
            if (other.gameObject.CompareTag("merketAPP"))
            {
                Marketb = other.gameObject;
            }
            if (other.gameObject.CompareTag("settingsAPP"))
            {
                Settingsb = other.gameObject;
            }
            if (other.gameObject.CompareTag("exitAPP"))
            {
                Exitb = other.gameObject;
            }
            if(other.gameObject.CompareTag("BuyLemon"))
            {
                BuyLemon = other.gameObject;
            }
            if(other.gameObject.CompareTag("BuySugah"))
            {
                BuySugar = other.gameObject;
            }
            if (other.gameObject.CompareTag("BuyCups"))
            {
                BuyCups = other.gameObject;
            }
            if (other.gameObject.CompareTag("BuyIce"))
            {
                BuyIce = other.gameObject;
            }
            if (other.gameObject.CompareTag("ExitMark"))
            {
                SXmark = other.gameObject;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.name!="base")
            if (!tine)
            {
                grabbedOb = null;
                butonUp = null;
                butonDown = null;
                grabbedPahar = null;
                grabbedLamaie = null;
                grabbedZahar = null;
                grabbedGheata = null;
            }
    }

    private void paharSpawn()
    {
        /*GameObject prefab_obj = Instantiate(
            pahar,
            new Vector3(this.transform.position.x, this.transform.position.y , this.transform.position.z),
            Quaternion.identity,
            transform
            );
        prefab_obj.name = "cup";
        prefab_obj.transform.SetParent(null);
        prefab_obj.transform.localScale = new Vector3(5, 5, 0);
*/
      cup =  Instantiate(pahar, this.transform.position, Quaternion.identity);
    }
    private void lamaieSpawn()
    {
        lemon = Instantiate(lamaie, this.transform.position, Quaternion.identity);
        lemon.transform.SetParent(lamai.transform);
    }
    private void zaharSpawn()
    {
        sugar = Instantiate(zahar, this.transform.position, Quaternion.identity);
    }
    private void gheataSpawn()
    {
        ice = Instantiate(gheata, this.transform.position, Quaternion.identity);
    }
}
