using UnityEngine;

public class tacleMove : MonoBehaviour
{
    public Sprite curved;
    public Sprite straight;
    public float followSpeed = 15f;
    private Vector3 distObMous;
    private bool urmareste = false;
    private bool stop = false;


    //grabbing stuff
    private GameObject grabbedOb;
    private GameObject grabbedPahar;
    private GameObject grabbedLamaie;
    private bool tine = false;

    private GameObject butonDown;
    private GameObject butonUp;
    //prfabs
    private GameObject cup;
    public GameObject pahar;
    public GameObject lamaie;
    private GameObject lemon;
    void Update()
    {   // doar il face sa devina inapoi dynamic ;  restul se reactiveaza de la sine
        if (Input.GetKeyUp(KeyCode.Z))
        {
            if (grabbedOb != null)
            {
                grabbedOb.GetComponent<BoxCollider2D>().isTrigger = false;
                grabbedOb = null;
            }
            if (grabbedPahar != null)
            {
                grabbedPahar = null;
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
                if (grabbedOb.GetComponent<BoxCollider2D>().isTrigger == false)
                    grabbedOb.GetComponent<BoxCollider2D>().isTrigger = true;
            
            Vector3 mouseReal2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 targetPos = mouseReal2 + distObMous;
            grabbedOb.GetComponent<Rigidbody2D>().MovePosition(Vector2.Lerp(GetComponent<Rigidbody2D>().position, targetPos, followSpeed * Time.fixedDeltaTime));
        }

    }

    //Grabbing stuff
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Grabbable"))
        {
            grabbedOb = other.gameObject;
        }
        if (other.gameObject.CompareTag("ScoatePahar"))
        {
            grabbedPahar = other.gameObject;
        }
        if (other.gameObject.CompareTag("ScoateLamaie"))
        {
            grabbedLamaie = other.gameObject;
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
            }
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
        lemon = Instantiate(lamaie, this.transform.position, Quaternion.identity);
    }

}
