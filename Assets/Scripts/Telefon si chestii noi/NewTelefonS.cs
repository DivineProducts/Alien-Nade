using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq;
using System.Collections;

public class NewTelefonS : MonoBehaviour
{
    public GameObject ThePhonee;
    public GameObject tel;
    public GameObject Telf;

    public GameObject MarketSistem;
    public GameObject TMarketpg1;
    public GameObject TMarketpg2;

    public GameObject PahareStac;
    public GameObject Lemons;
    public GameObject Orange;
    public GameObject Kiwi;
    public GameObject Sugah;
    public GameObject Ice;

    public GameObject Blime;
    public GameObject SLime;
    public GameObject BOrange;
    public GameObject SOrange;
    public GameObject BKiwi;
    public GameObject SKiwi;
    public GameObject BCup;
    public GameObject SCup;
    public GameObject BSugar;
    public GameObject SSugar;
    public GameObject BIce;
    public GameObject SIce;
    public GameObject BCutitlv2;
    public GameObject SCutitlv2;
    public GameObject BCutitlv3;
    public GameObject SCutitlv3;
    public GameObject BCheese;
    public GameObject SCheese;
    public GameObject BBlender;
    public GameObject SBlender;


    private int buylime = 2;
    private int buyorange = 2;
    private int buykiwi = 2;
    private int buycups = 2;
    private int buysugar = 2;
    private int buyice = 2;
    private int buycutitlv2 = 2;
    private int buycutitlv3 = 2;
    private int buycheese = 2;
    private int buyblender = 2;

    public float Tdown = 10f;

    private Coroutine limeTimerRef;
    private Coroutine orangeTimerRef;
    private Coroutine cupsTimerRef;
    private Coroutine zahTimerRef;
    private Coroutine kiwiTimerRef;
    private Coroutine iceTimerRef;

    
    public TextMeshProUGUI TimIce;
    public TextMeshProUGUI TimZah;
    public TextMeshProUGUI TimCup;
    public TextMeshProUGUI TimLim;
    public TextMeshProUGUI TimOrg;
    public TextMeshProUGUI TimKiw;

    //save system stuff
    public GameObject baniJoc;
    //esta e unloaded, nu are cum sa mearga baiii
    public void Start()
    { 
        Debug.Log(Static.continuam);
        if (Static.continuam)
        {
            Debug.Log("a dat load");
            GameData data = SaveSystem.Load();
            Debug.Log(data.gheataRamasa);
            baniJoc.transform.localScale = new Vector3(data.baniScaleX, data.baniScaleY, data.baniScaleZ);
            baniJoc.transform.position = new Vector3(data.baniPosX, data.baniPosY, data.baniPosZ);

            Ice.GetComponent<gheataControl>().gheataRamasa = data.gheataRamasa+1;
            Ice.GetComponent<gheataControl>().schimbaSprite();
            PahareStac.GetComponent<pahareControl>().pahareRamase = data.paharRamasa + 1;
            PahareStac.GetComponent<pahareControl>().schimbaSprite();
            Sugah.GetComponent<zaharControl>().zaharRamase = data.zaharRamasa + 1;
            Sugah.GetComponent<zaharControl>().schimbaSprite();
            Lemons.GetComponent<lamaiControl>().lamaiRamase = data.lamaieRamasa + 1;
            Lemons.GetComponent<lamaiControl>().schimbaSprite();
            Kiwi.GetComponent<lamaiControl>().lamaiRamase = data.kiwiRamasa + 1;
            Kiwi.GetComponent<lamaiControl>().schimbaSprite();
            Orange.GetComponent<lamaiControl>().lamaiRamase = data.portocalaRamasa + 1;
            Orange.GetComponent<lamaiControl>().schimbaSprite();

        }
        Static.continuam = false;
        tel.SetActive(false);
    }
    public void QuitAlienade()
    {
        SaveSystem.Save(baniJoc.transform.localScale, baniJoc.transform.position, Ice.GetComponent<gheataControl>().gheataRamasa,PahareStac.GetComponent<pahareControl>().pahareRamase,Sugah.GetComponent<zaharControl>().zaharRamase,Lemons.GetComponent<lamaiControl>().lamaiRamase,Kiwi.GetComponent<lamaiControl>().lamaiRamase, Orange.GetComponent<lamaiControl>().lamaiRamase);
        Application.Quit();
        Debug.Log("Am iesit");
    }
 
    public void BackButton()
    {
        Telf.SetActive(false);
    }

    public void SettingsOptions()
    {

    }

    public void MarketBut()
    {
        Telf.SetActive(false);
        MarketSistem.SetActive(true);
    }

    public void Nextpag()
    {
        TMarketpg1.SetActive(false);
        TMarketpg2.SetActive(true);
    }

    public void BackPag()
    {
        TMarketpg2.SetActive(false);
        TMarketpg1.SetActive(true);
    }

    public void CloseMarket()
    {
        Telf.SetActive(true);
        MarketSistem.SetActive(false);
        TMarketpg2.SetActive(false);
        TMarketpg1.SetActive(true);

    }
    

    //ALL THE BOOLS
    #region
    public void Buylime()
    {
        if (buylime > 0)
        {
            Blime.SetActive(false);
            SLime.SetActive(true);
            buylime = 0;
        }
        else if(buylime==0)
        {
            Blime.SetActive(true);
            SLime.SetActive(false);
            buylime = 1;
        }


    }
    public void Buyorange()
    {
        if (buyorange > 0)
        {
            BOrange.SetActive(false);
            SOrange.SetActive(true);
            buyorange = 0;
        }
        else if (buyorange == 0)
        {
            BOrange.SetActive(true);
            SOrange.SetActive(false);
            buyorange = 1;
        }
    }
    public void Buykiwi()
    {
        if (buykiwi > 0)
        {
            BKiwi.SetActive(false);
            SKiwi.SetActive(true);
            buykiwi = 0;
        }
        else if (buykiwi == 0)
        {
            BKiwi.SetActive(true);
            SKiwi.SetActive(false);
            buykiwi = 1;
        }
    }
    public void Buycups()
    {
        if (buycups > 0)
        {
            BCup.SetActive(false);
            SCup.SetActive(true);
            buycups = 0;
        }
        else if (buycups == 0)
        {
            BCup.SetActive(true);
            SCup.SetActive(false);
            buycups = 1;
        }
    }
    public void Buysugar()
    {
        if (buysugar > 0)
        {
            BSugar.SetActive(false);
            SSugar.SetActive(true);
            buysugar = 0;
        }
        else if (buysugar == 0)
        {
            BSugar.SetActive(true);
            SSugar.SetActive(false);
            buysugar = 1;
        }
    }
    public void Buyice()
    {
        if (buyice > 0)
        {
            BIce.SetActive(false);
            SIce.SetActive(true);
            buyice = 0;
        }
        else if (buyice == 0)
        {
            BIce.SetActive(true);
            SIce.SetActive(false);
            buyice = 1;
        }
    }
    public void Buycutitlv2()
    {
        if (buycutitlv2 > 0)
        {
            BCutitlv2.SetActive(false);
            SCutitlv2.SetActive(true);
            buycutitlv2 = 0;
        }
        else if (buycutitlv2 == 0)
        {
            BCutitlv2.SetActive(true);
            SCutitlv2.SetActive(false);
            buycutitlv2 = 1;
        }
    }
    public void Buycutitlv3()
    {
        if (buycutitlv3 > 0)
        {
            BCutitlv3.SetActive(false);
            SCutitlv3.SetActive(true);
            buycutitlv3 = 0;
        }
        else if (buycutitlv3 == 0)
        {
            BCutitlv3.SetActive(true);
            SCutitlv2.SetActive(false);
            buycutitlv3 = 1;
        }
    }
    public void Buycheese()
    {
        if (buycheese > 0)
        {
            BCheese.SetActive(false);
            SCheese.SetActive(true);
            buycheese = 0;
        }
        else if (buycheese == 0)
        {
            BCheese.SetActive(true);
            SCheese.SetActive(false);
            buycheese = 1;
        }
    }
    public void Buyblender()
    {
        if (buyblender > 0)
        {
            BBlender.SetActive(false);
            SBlender.SetActive(true);
            buyblender = 0;
        }
        else if (buyblender == 0)
        {
            BBlender.SetActive(true);
            SBlender.SetActive(false);
            buyblender = 1;
        }
    }
    #endregion
    /////


    public void Buy()
    {
        if (buylime == 0)
        {
            TimLim.gameObject.SetActive(true);
            if (limeTimerRef == null)
            {
                limeTimerRef=
                StartCoroutine(Timer(TimLim, 15f, () =>
                {
                    Lemons.GetComponent<lamaiControl>().lamaiRamase = 10;
                    Lemons.GetComponent<lamaiControl>().schimbaSprite();
                    Blime.SetActive(true);
                    SLime.SetActive(false);
                    buylime = 1;
                    limeTimerRef = null;
                    TimLim.gameObject.SetActive(false);
                }));
                
            }


            /*Lemons.GetComponent<lamaiControl>().lamaiRamase = 10;
            Lemons.GetComponent<lamaiControl>().schimbaSprite();
            Blime.SetActive(true);
            SLime.SetActive(false);
            buylime = 1;*/
        }
        if (buyorange == 0)
        {
            TimOrg.gameObject.SetActive(true);
            if (orangeTimerRef == null)
            {
                orangeTimerRef =
                StartCoroutine(Timer(TimOrg, 15f, () =>
                {
                    Orange.GetComponent<lamaiControl>().lamaiRamase = 10;
                    Orange.GetComponent<lamaiControl>().schimbaSprite();
                    BOrange.SetActive(true);
                    SOrange.SetActive(false);
                    buyorange = 1;
                    orangeTimerRef = null;
                    TimOrg.gameObject.SetActive(false);
                }));

            }
            /*Orange.GetComponent<lamaiControl>().lamaiRamase = 10;
            Orange.GetComponent<lamaiControl>().schimbaSprite();
            BOrange.SetActive(true);
            SOrange.SetActive(false);
            buyorange = 1;*/
        }
        if (buykiwi == 0)
        {
            TimKiw.gameObject.SetActive(true);
            if (kiwiTimerRef == null)
            {
                kiwiTimerRef =
                StartCoroutine(Timer(TimKiw, 15f, () =>
                {
                    Kiwi.GetComponent<lamaiControl>().lamaiRamase = 10;
                    Kiwi.GetComponent<lamaiControl>().schimbaSprite();
                    BKiwi.SetActive(true);
                    SKiwi.SetActive(false);
                    buykiwi = 1;
                    kiwiTimerRef = null;
                    TimKiw.gameObject.SetActive(false);
                }));

            }
            /*Kiwi.GetComponent<lamaiControl>().lamaiRamase = 10;
            Kiwi.GetComponent<lamaiControl>().schimbaSprite();
            BKiwi.SetActive(true);
            SKiwi.SetActive(false);
            buykiwi = 1;*/
        }
        if (buycups == 0)
        {
            TimCup.gameObject.SetActive(true);
            if (cupsTimerRef == null)
            {
                cupsTimerRef =
                StartCoroutine(Timer(TimCup, 15f, () =>
                {
                    PahareStac.GetComponent<pahareControl>().pahareRamase = 7;
                    PahareStac.GetComponent<pahareControl>().schimbaSprite();
                    BCup.SetActive(true);
                    SCup.SetActive(false);
                    buycups = 1;
                    cupsTimerRef = null;
                    TimCup.gameObject.SetActive(false);
                }));

            }
            /*PahareStac.GetComponent<pahareControl>().pahareRamase = 7;
            PahareStac.GetComponent<pahareControl>().schimbaSprite();
            BCup.SetActive(true);
            SCup.SetActive(false);
            buycups = 1;*/
        }
        if (buysugar == 0)
        {
            TimZah.gameObject.SetActive(true);
            if (zahTimerRef == null)
            {
                zahTimerRef =
                StartCoroutine(Timer(TimZah, 15f, () =>
                {
                    Sugah.GetComponent<zaharControl>().zaharRamase = 6;
                    BSugar.SetActive(true);
                    SSugar.SetActive(false);
                    buysugar = 1;
                    zahTimerRef = null;
                    TimZah.gameObject.SetActive(false);
                }));

            }
           /* Sugah.GetComponent<zaharControl>().zaharRamase = 6;
            BSugar.SetActive(true);
            SSugar.SetActive(false);
            buysugar = 1;*/
        }
        if (buyice==0)
        {
            TimIce.gameObject.SetActive(true);
            if (iceTimerRef == null)
            {
                iceTimerRef =
                StartCoroutine(Timer(TimIce, 15f, () =>
                {
                    Ice.GetComponent<gheataControl>().gheataRamasa = 7;
                    Ice.GetComponent<gheataControl>().schimbaSprite();
                    BIce.SetActive(true);
                    SIce.SetActive(false);
                    buyice = 1;
                    iceTimerRef = null;
                    TimIce.gameObject.SetActive(false);
                }));

            }
           /* Ice.GetComponent<gheataControl>().gheataRamasa = 7;
            Ice.GetComponent<gheataControl>().schimbaSprite();
            BIce.SetActive(true);
            SIce.SetActive(false);
            buyice = 1;*/
        }
        
    }


    public IEnumerator Timer(TextMeshProUGUI Timp,float Tdown, System.Action onComplete)
    {

        float Ctime = Tdown;
        while (Ctime > 0)
        {

            Timp.text = Ctime.ToString();
            yield return new WaitForSeconds(1f);
            Ctime -= 1f;

        }
        Timp.text = "0";
        if (onComplete != null)
        {
            onComplete.Invoke();
        }

    }
}
