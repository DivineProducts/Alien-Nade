using UnityEngine;

public class BehaviourOfPahare : MonoBehaviour
{
    public int CntLamaiP;
    public int CntZaharP;
    public int CntGheataP;
    public GameObject ObiectAtins;
    public GameObject ObiectP;

    public Sprite CuGheata;
    public Sprite CuLimon;
   
   
    void Start()
    {
        ObiectP = GameObject.Find("om");
    }

  
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.TryGetComponent<IdentificareGheata>(out IdentificareGheata scriptIce) && ObiectP.gameObject.GetComponent<oamenisibanii>().Item1 == true)
        {
            Destroy(other.gameObject);
            CntGheataP++;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = CuGheata;
        }
        if (other.gameObject.TryGetComponent<FromWaterToLemonade>(out FromWaterToLemonade scriptLime)&& other.gameObject.GetComponent<FromWaterToLemonade>().cntjuice>0)
        {
          
            other.gameObject.GetComponent<FromWaterToLemonade>().cntjuice--;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = CuLimon;
            ObiectP.gameObject.GetComponent<oamenisibanii>().Item1 = true;
        }
        if (other.gameObject.TryGetComponent<IdentificareZahar>(out IdentificareZahar scriptZah))
        {
            Destroy(other.gameObject);
            CntZaharP++;
        }

    }

   


}
