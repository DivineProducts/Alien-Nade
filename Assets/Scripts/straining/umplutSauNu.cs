using UnityEngine;

public class umplutSauNu : MonoBehaviour
{
    public Sprite sucLamaie;
    public Sprite sucPortocala;
    public Sprite sucKiwi;
    public GameObject strainer;
    public float capacitate = 0f;
    public int tipFruct = 0;
    public bool umplut = false;
    public bool EsteGol()
    {
        return tipFruct == 0;
    }
    public bool PoateStoarce(string fruct)
    {
        if (tipFruct == 0)return true;
        if (fruct == "Lemon" && tipFruct == 1) return true;
        if (fruct == "Kiwi" && tipFruct == 2)return true;
        if (fruct == "Orange" && tipFruct == 3) return true;
        return false;
    }

    public void AdaugaFruct(string fruct, float cantitate)
    {
        if (tipFruct == 0)
        {
            if (fruct == "Lemon")tipFruct = 1;
            else if (fruct == "Kiwi")tipFruct = 2;
            else if (fruct == "Orange") tipFruct = 3;
        }
        capacitate += cantitate;
        if (capacitate >= 300)
        {
            if (fruct == "Lemon") this.GetComponent<SpriteRenderer>().sprite=sucLamaie;
            else if (fruct == "Kiwi") this.GetComponent<SpriteRenderer>().sprite = sucKiwi;
            else if (fruct == "Orange") this.GetComponent<SpriteRenderer>().sprite = sucPortocala;
            umplut = true;
        }
    }
    public void Goleste()
    {
        capacitate = 0;
        tipFruct = 0;
        umplut = false;
    }
}
