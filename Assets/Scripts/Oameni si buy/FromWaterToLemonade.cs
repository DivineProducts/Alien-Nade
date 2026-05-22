using UnityEngine;

public class FromWaterToLemonade : MonoBehaviour
{
    public Sprite Apa;
    public Sprite Lemonade;
    public int cntjuice;
    void Update()
    {
        if (cntjuice == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Apa;
        }
        if (cntjuice == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Lemonade;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {if (other.gameObject.TryGetComponent<umplutSauNu>(out umplutSauNu scriptstorc1))
        {
            
            if (scriptstorc1.umplut == true && cntjuice==0)
            {
                scriptstorc1.umplut = false;
                cntjuice++;
            }
            
        }
    }

    }
