using Unity.VisualScripting;
using UnityEngine;

public class NewTelefonS : MonoBehaviour
{
    public GameObject ThePhonee;
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

    public void QuitAlienade()
    {
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
            Lemons.GetComponent<lamaiControl>().lamaiRamase = 10;
            Lemons.GetComponent<lamaiControl>().schimbaSprite();
            Blime.SetActive(true);
            SLime.SetActive(false);
            buylime = 1;
        }
        if (buyorange == 0)
        {

        }
        if (buykiwi == 0)
        {

        }
        if (buycups == 0)
        {
            PahareStac.GetComponent<pahareControl>().pahareRamase = 7;
            PahareStac.GetComponent<pahareControl>().schimbaSprite();
            BCup.SetActive(true);
            SCup.SetActive(false);
            buycups = 1;
        }
        if (buysugar == 0)
        {
            Sugah.GetComponent<zaharControl>().zaharRamase = 6;
            BSugar.SetActive(true);
            SSugar.SetActive(false);
            buysugar = 1;
        }
        if (buyice==0)
        {
            Ice.GetComponent<gheataControl>().gheataRamasa = 7;
            Ice.GetComponent<gheataControl>().schimbaSprite();
            BIce.SetActive(true);
            SIce.SetActive(false);
            buyice = 1;
        }
        
    }

}
