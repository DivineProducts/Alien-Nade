using UnityEngine;

public class lamaiControl : MonoBehaviour
{
    public int lamaiRamase;

    public Sprite jumate;
    public Sprite gol;
    public Sprite plin;

    public void scade()
    {
        lamaiRamase--;
    }
    public void schimbaSprite()
    {
        lamaiRamase--;
        if (lamaiRamase == 9)
        { this.gameObject.GetComponent<SpriteRenderer>().sprite = plin; }
        if (lamaiRamase == 6)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = jumate;
        /*if (lamaiRamase == 3)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = treime;*/
        if (lamaiRamase == 0)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = gol;
    }
}
