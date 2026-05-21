using UnityEngine;

public class BehaviourOfPahare : MonoBehaviour
{
    public int CntLamaiP;
    public int CntZaharP;
    public int CntGheataP;
    public GameObject ObiectAtins;

    public Sprite CuGheata;
    public Sprite CuLimon;
   
   
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.TryGetComponent<IdentificareGheata>(out IdentificareGheata scriptIce))
        {
            Destroy(other.gameObject);
            CntGheataP++;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = CuGheata;
        }
        if (other.gameObject.TryGetComponent<IdentificareLamaiB>(out IdentificareLamaiB scriptLime))
        {
            Destroy(other.gameObject);

        }
        if (other.gameObject.TryGetComponent<IdentificareZahar>(out IdentificareZahar scriptZah))
        {
            Destroy(other.gameObject);
            CntZaharP++;
        }

    }

   


}
