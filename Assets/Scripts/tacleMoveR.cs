using UnityEngine;

public class tacleMoveR : MonoBehaviour
{
    public Sprite curved;
    public Sprite straight;
    public float followSpeedR = 15f;
    private Vector3 distObMousR;
    private bool urmaresteR = false;
    private bool stopR = false;

    void Update()
    {   // doar il face sa devina inapoi dynamic ;  restul se reactiveaza de la sine
        if (Input.GetKeyUp(KeyCode.X))
        {
            this.GetComponent<SpriteRenderer>().sprite = straight;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
        //  transforma obiectul intrunul static
        if (Input.GetKeyDown(KeyCode.X))
        {
            this.GetComponent<SpriteRenderer>().sprite = curved;
            urmaresteR = false;
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            GetComponent<Rigidbody2D>().angularVelocity = 0f;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        }

        // uff, 0=LeftMouse; 1=RightMouse.... bagamias piciarele
        if (Input.GetMouseButtonDown(1) && !stopR)
        {
            urmaresteR = true;
            //Vector3???
            Vector2 mouseReal = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Vector2 mous2d = mouseReal;
            distObMousR = GetComponent<Rigidbody2D>().position - mouseReal;
        }
        else
        if (Input.GetMouseButtonUp(1))
        {
            urmaresteR = false;
        }
    }
    void FixedUpdate()
    {
        if (urmaresteR == true && stopR == false)
        {
            Vector3 mouseReal2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 targetPos = mouseReal2 + distObMousR;
            GetComponent<Rigidbody2D>().MovePosition(Vector2.Lerp(GetComponent<Rigidbody2D>().position, targetPos, followSpeedR * Time.fixedDeltaTime));
        }
    }
}

