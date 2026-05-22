using UnityEngine;

public class tacleMoveR : MonoBehaviour
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
    public GameObject storsMiniGame;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            urmareste = false;
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            GetComponent<Rigidbody2D>().angularVelocity = 0f;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        }
        // doar il face sa devina inapoi dynamic ;  restul se reactiveaza de la sine
        if (Input.GetKeyUp(KeyCode.X))
        {
            if (grabbedOb != null)
            {
                if (grabbedOb.name == "storcator" && GameObject.Find("storcator").transform.GetComponent<umplutSauNu>().capacitate<300)
                    Instantiate(storsMiniGame, new Vector3(-6.86999989f, -1.5f, 0), Quaternion.identity);
                grabbedOb.GetComponent<BoxCollider2D>().isTrigger = false;
            }
            grabbedOb = null;
            if (grabbedPahar != null)
                grabbedPahar = null;
            if (butonUp != null)
                butonUp = null;
            if (butonDown != null)
                butonDown = null;
            if (grabbedLamaie != null)
                grabbedLamaie = null;
            if (grabbedZahar != null)
                grabbedZahar = null;
            if (grabbedGheata != null)
                grabbedGheata = null;
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
        if (Input.GetKeyDown(KeyCode.X))
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
            if (grabbedLamaie != null)
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
                butonUp.GetComponent<cameraMove>().move();
                butonUp = null;
            }

        }

        // uff, 0=LeftMouse; 1=RightMouse.... bagamias piciarele
        if (Input.GetMouseButtonDown(1) && !stop)
        {
            urmareste = true;
            Vector2 mouseReal = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            distObMous = GetComponent<Rigidbody2D>().position - mouseReal;
        }
        else
        if (Input.GetMouseButtonUp(1))
        {
            urmareste = false;
        }
    }
    void FixedUpdate()
    {
        if (urmareste == true && stop == false)
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
            if (other.gameObject.CompareTag("ScoateZahar") && other.GetComponent<zaharControl>().zaharRamase != 0)
            {
                if (other.gameObject.GetComponent<zaharControl>().zaharRamase > 0)
                    grabbedZahar = other.gameObject;
            }
            if (other.gameObject.CompareTag("ScoateGheata"))
            {
                if (other.gameObject.GetComponent<gheataControl>().gheataRamasa > 0)
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

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == grabbedOb)
        {
            if (!tine)
            {
                grabbedOb.GetComponent<BoxCollider2D>().isTrigger = false;
                grabbedOb = null;
                butonUp = null;
                butonDown = null;
                grabbedPahar = null;
                grabbedLamaie = null;
                grabbedZahar = null;
                grabbedGheata = null;
            }
        }
    }

    private void paharSpawn()
    {
        cup = Instantiate(pahar, this.transform.position, Quaternion.identity);
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
