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
    public int folosiri = 0;


    public void Update()
    {
        if (folosiri == 0)
        {
           this.gameObject.GetComponent<SpriteRenderer>().sprite = Apa;
        }
    }
    void fa()
    {
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == Lemonade)
        {
            if (cntjuice == 2)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = LamiKiwi;
                folosiri = 3;
            }
            if (cntjuice == 3)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = LamiPort;
                folosiri = 3;
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == Kiwinade)
        {
            if (cntjuice == 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = LamiKiwi;
                folosiri = 3;
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == Portonade)
        {
            if (cntjuice == 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = LamiPort;
                folosiri = 3;
            }
        }
        else if (cntjuice == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Lemonade;
            folosiri = 3;


        }
        else if (cntjuice == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Kiwinade;
            folosiri = 3;

        }
       else  if (cntjuice == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Portonade;
            folosiri = 3;

        }
        
        else if (cntjuice == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Apa;
            folosiri = 3;
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
