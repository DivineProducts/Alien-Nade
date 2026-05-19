using UnityEngine;

public class pahareControl : MonoBehaviour
{
    public int pahareRamase;
    public Sprite jumate;
    public Sprite treime;
    
    public void scade()
    {
        pahareRamase--;
    }
    public void schimbaSprite()
    {
        pahareRamase--;
        if (pahareRamase == 4)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = jumate;
        if (pahareRamase == 2)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = treime;
        if (pahareRamase == 0)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
    }
}
