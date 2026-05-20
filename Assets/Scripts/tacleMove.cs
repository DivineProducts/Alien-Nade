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
    private bool tine = false;

    private GameObject butonDown;
    //prfabs
    private GameObject cup;
    public GameObject pahar;
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
            if (butonDown != null)
            {
                butonDown.GetComponent<cameraMove>().down();
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
        if (other.gameObject.CompareTag("down"))
        {
            butonDown = other.gameObject;
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

}
