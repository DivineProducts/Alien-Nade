using UnityEngine;

public class gheataControl : MonoBehaviour
{
    public int gheataRamasa;
    public Sprite jumate;
    public Sprite treime;
    public Sprite start;
    public void schimbaSprite()
    {
        gheataRamasa--;
        if(gheataRamasa >=6)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = start;
        if (gheataRamasa < 6 && gheataRamasa>=3)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = jumate;
        if (gheataRamasa <3 && gheataRamasa>0)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = treime;
        if (gheataRamasa == 0)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
    }
}

