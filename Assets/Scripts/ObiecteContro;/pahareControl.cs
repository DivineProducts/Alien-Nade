using UnityEngine;

public class pahareControl : MonoBehaviour
{
    public int pahareRamase;
    public Sprite jumate;
    public Sprite treime;
    public Sprite plin;
    public void scade()
    {
        pahareRamase--;
    }
    public void schimbaSprite()
    {
        pahareRamase--;
        if (pahareRamase >= 6)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = plin;
        if (pahareRamase >= 4 && pahareRamase<6)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = jumate;
        if (pahareRamase >= 1 && pahareRamase<4)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = treime;
        if (pahareRamase < 1)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
    }
}
