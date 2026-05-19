using UnityEngine;

public class tacleMove : MonoBehaviour
{
    public Sprite curved;
    public Sprite straight;
    public float followSpeed = 15f;
    private Vector3 distObMous;
    private bool urmareste = false;
    private bool stop = false;

    void Update()
    {   // doar il face sa devina inapoi dynamic ;  restul se reactiveaza de la sine
        if (Input.GetKeyUp(KeyCode.Z))
        {
            this.GetComponent<SpriteRenderer>().sprite = straight;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
        //  transforma obiectul intrunul static
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.GetComponent<SpriteRenderer>().sprite = curved;
            urmareste = false;
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            GetComponent<Rigidbody2D>().angularVelocity = 0f;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
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
    }
}
