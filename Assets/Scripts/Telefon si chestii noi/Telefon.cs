using UnityEngine;

public class Telefon : MonoBehaviour
{
    public GameObject Sphone;
    public GameObject SButoane;
    public GameObject SXmark;
    public GameObject SBackb;
    public GameObject SMarketb;
    public GameObject SSettingsb;
    public GameObject ExitbS;

    public GameObject PahareStac;
    public GameObject Lemons;
    public GameObject Sugah;
    public GameObject Ice;


    public GameObject ALLMArkB;
    public GameObject BuyLemon;
    public GameObject BuySugar;
    public GameObject BuyCups;
    public GameObject BuyIce;

    public Sprite InterSprite;
    public Sprite FaceNormal;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    
    public void DeschideMarket()
    {
       SButoane.SetActive(false);
       Sphone.gameObject.GetComponent<SpriteRenderer>().sprite = InterSprite;
       ALLMArkB.SetActive(true);
       
    }

    public void BuyC()
    {//scade bani
        PahareStac.GetComponent<pahareControl>().pahareRamase = 7;
        PahareStac.GetComponent<pahareControl>().schimbaSprite();
    }

    public void BuyZ()
    {
        Sugah.GetComponent<zaharControl>().zaharRamase = 6;
       
    }

    public void BuyL()
    {
        Lemons.GetComponent<lamaiControl>().lamaiRamase = 10 ;
        Lemons.GetComponent<lamaiControl>().schimbaSprite();
    }

    public void BuyI()
    {
        Ice.GetComponent<gheataControl>().gheataRamasa = 7;
        Ice.GetComponent<gheataControl>().schimbaSprite();
    }

    public void InchideMarket()
    {
        SButoane.SetActive(true);
        Sphone.gameObject.GetComponent<SpriteRenderer>().sprite = FaceNormal;
        ALLMArkB.SetActive(false);
    }



}
