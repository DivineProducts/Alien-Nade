using UnityEngine;

public class FromWaterToLemonade : MonoBehaviour
{
    public Sprite Apa;
    public Sprite Lemonade;
    public Sprite Kiwinade;
    public Sprite Portonade;
    public Sprite LamiPort;
    public Sprite LamiKiwi;
    public int cntjuice;
    void fa()
    {
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == Lemonade)
        {
            if (cntjuice == 2)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = LamiKiwi;
            }
            if (cntjuice == 3)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = LamiPort;
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == Kiwinade)
        {
            if (cntjuice == 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = LamiKiwi;
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == Portonade)
        {
            if (cntjuice == 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = LamiPort;
            }
        }
        else if (cntjuice == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Lemonade;
           
            
        }
        else if (cntjuice == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Kiwinade;
            
        }
       else  if (cntjuice == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Portonade;
          
        }
        
        else if (cntjuice == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Apa;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {if (other.gameObject.TryGetComponent<umplutSauNu>(out umplutSauNu scriptstorc1))
        {
            
            if (scriptstorc1.umplut == true)
            {
                
                scriptstorc1.umplut = false;
                /*if(other.GetComponent<SpriteRenderer>().sprite.name==other.GetComponent<umplutSauNu>().sucLamaie.name)
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = Lemonade;*/
                /*cntjuice++;*/
                cntjuice = other.gameObject.GetComponent<umplutSauNu>().tipFruct;
                
                fa();
                other.gameObject.GetComponent<umplutSauNu>().Goleste();
            }
            
        }
    }

    }
