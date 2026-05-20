using UnityEngine;

public class gheataControl : MonoBehaviour
{
    public int gheataRamasa;
    public Sprite jumate;
    public Sprite treime;
    public void schimbaSprite()
    {
        gheataRamasa--;
        if (gheataRamasa == 4)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = jumate;
        if (gheataRamasa == 2)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = treime;
        if (gheataRamasa == 0)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
    }
}

