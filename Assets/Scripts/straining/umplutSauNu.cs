using UnityEngine;

public class umplutSauNu : MonoBehaviour
{
    public bool umplut;
    public Sprite plin;
    public Sprite gol;
    public float capacitate;
    /*private void OnValidate()
    {
        if (umplut)
            this.GetComponent<SpriteRenderer>().sprite = plin;
        else this.GetComponent<SpriteRenderer>().sprite = gol;
    }*/
    private void Update()
    {
        if (umplut)
            this.GetComponent<SpriteRenderer>().sprite = plin;
        else this.GetComponent<SpriteRenderer>().sprite = gol;
    }
}
