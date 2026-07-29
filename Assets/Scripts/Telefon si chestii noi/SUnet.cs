using UnityEngine;
using UnityEngine.UI;


public class SUnet : MonoBehaviour
{

    public GameObject Paharmuz;
    public GameObject Paharsfx;

    public Sprite PaharGol;

    public Sprite SpM1;
    public Sprite SpM2;
    public Sprite SpM3;
    public Sprite SpM4;

    public Sprite SpS1;
    public Sprite SpS2;
    public Sprite SpS3;
    public Sprite SpS4;

    AudioManeger audioManeger;

    public void Start()
    {
        audioManeger = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManeger>();
    }
    public void muizcup()
    {
        audioManeger.SongVolumePlus();
        if (Paharmuz.GetComponent<Image>().sprite == PaharGol)
        {
            Paharmuz.GetComponent<Image>().sprite = SpM1;
        }
        else if(Paharmuz.GetComponent<Image>().sprite == SpM1)
        {
            Paharmuz.GetComponent<Image>().sprite= SpM2;
        }
        else if (Paharmuz.GetComponent<Image>().sprite == SpM2)
        {
            Paharmuz.GetComponent<Image>().sprite=SpM3;
        }
        else if (Paharmuz.GetComponent<Image>().sprite==SpM3)
        {
            Paharmuz.GetComponent<Image>().sprite = SpM4;
        }
    }

    public void muizcdown()
    {
        audioManeger.SongVolumeMinus();
        if (Paharmuz.GetComponent<Image>().sprite == SpM1)
        {
            Paharmuz.GetComponent<Image>().sprite = PaharGol;
        }
        else if (Paharmuz.GetComponent<Image>().sprite == SpM2)
        {
            Paharmuz.GetComponent<Image>().sprite = SpM1;
        }
        else if (Paharmuz.GetComponent<Image>().sprite == SpM3)
        {
            Paharmuz.GetComponent<Image>().sprite = SpM2;
        }
        else if ( Paharmuz.GetComponent<Image>().sprite==SpM4)
        {
            Paharmuz.GetComponent<Image>().sprite = SpM3;
        }
    }

    public void sfxup()
    {
        audioManeger.SFXVolumePlus();
        if (Paharsfx.GetComponent<Image>().sprite == PaharGol)
        {
            Paharsfx.GetComponent<Image>().sprite = SpS1;
        }
        else if( Paharsfx.GetComponent<Image>().sprite == SpS1)
        {
            Paharsfx.GetComponent<Image>().sprite = SpS2;
        }
        else if( Paharsfx.GetComponent<Image>().sprite == SpS2)
        {
            Paharsfx.GetComponent<Image>().sprite = SpS3;
        }
        else if( Paharsfx.GetComponent<Image>().sprite == SpS3)
        {
            Paharsfx.GetComponent<Image>().sprite = SpS4;
        }
    }

    public void sfxdown()
    {
        audioManeger.SFXVolumeMinus();
        if (Paharsfx.GetComponent<Image>().sprite == SpS4)
        {
            Paharsfx.GetComponent<Image>().sprite = SpS3;
        }
        else if (Paharsfx.GetComponent<Image>().sprite == SpS1)
        {
            Paharsfx.GetComponent<Image>().sprite = PaharGol;
        }
        else if (Paharsfx.GetComponent<Image>().sprite == SpS2)
        {
            Paharsfx.GetComponent<Image>().sprite = SpS1;
        }
        else if (Paharsfx.GetComponent<Image>().sprite == SpS3)
        {
            Paharsfx.GetComponent<Image>().sprite = SpS2;
        }
    }

}
