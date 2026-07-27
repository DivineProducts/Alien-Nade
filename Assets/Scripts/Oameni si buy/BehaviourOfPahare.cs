using UnityEngine;

public class BehaviourOfPahare : MonoBehaviour
{
    public int CntZaharP = 0;
    public int CntGheataP = 0;
    public GameObject ObiectAtins;
    public GameObject ObiectP;

    public Sprite CuGheataL;
    public Sprite CuLimon;
    public Sprite CuGheataO;
    public Sprite CuOrange;
    public Sprite CuGheataK;
    public Sprite CuKiwi;
    public Sprite CuGheataLO;
    public Sprite CuOrgLim;
    public Sprite CuGheataKO;
    public Sprite CuKiwiLim;

    public Sprite Lemonade;
    public Sprite Kiwinade;
    public Sprite Portonade;
    public Sprite LamiPort;
    public Sprite LamiKiwi;

    private SpriteRenderer mySpriteRenderer;
    private oamenisibanii scriptOm;

    void Start()
    {
        ObiectP = GameObject.Find("om");
        if (ObiectP != null)
        {
            scriptOm = ObiectP.GetComponent<oamenisibanii>();
        }
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        SpriteRenderer otherSpriteRenderer = other.GetComponent<SpriteRenderer>();

        if (other.gameObject.TryGetComponent<FromWaterToLemonade>(out FromWaterToLemonade scriptLime))
        {
            if (otherSpriteRenderer != null)
            {
                Sprite currentSprite = otherSpriteRenderer.sprite;

                if (currentSprite == Lemonade)
                {
                    scriptLime.folosiri--;
                    mySpriteRenderer.sprite = CuLimon;

                    if (scriptOm != null && scriptOm.VerifD == 1)
                    { scriptOm.Drink = true; }
                }
                else if (currentSprite == Portonade)
                {
                    scriptLime.folosiri--;
                    mySpriteRenderer.sprite = CuOrange;

                    if (scriptOm != null && scriptOm.VerifD == 2)
                    { scriptOm.Drink = true; }
                }
                else if (currentSprite == Kiwinade)
                {
                    scriptLime.folosiri--;
                    mySpriteRenderer.sprite = CuKiwi;

                    if (scriptOm != null && scriptOm.VerifD == 3)
                    { scriptOm.Drink = true; }
                }
                else if (currentSprite == LamiPort)
                {
                    scriptLime.folosiri--;
                    mySpriteRenderer.sprite = CuOrgLim;

                    if (scriptOm != null && scriptOm.VerifD == 4)
                    { scriptOm.Drink = true; }
                }
                else if (currentSprite == LamiKiwi)
                {
                    scriptLime.folosiri--;
                    mySpriteRenderer.sprite = CuKiwiLim;

                    if (scriptOm != null && scriptOm.VerifD == 5)
                    { scriptOm.Drink = true; }
                }
            }
            return;
        }

        if (other.gameObject.TryGetComponent<IdentificareGheata>(out IdentificareGheata scriptIce))
        {
            Destroy(other.gameObject);
            CntGheataP++;

            Sprite currentCupSprite = mySpriteRenderer.sprite;

            if (currentCupSprite == CuLimon) mySpriteRenderer.sprite = CuGheataL;
            else if (currentCupSprite == CuOrange) mySpriteRenderer.sprite = CuGheataO;
            else if (currentCupSprite == CuKiwi) mySpriteRenderer.sprite = CuGheataK;
            else if (currentCupSprite == CuOrgLim) mySpriteRenderer.sprite = CuGheataLO;
            else if (currentCupSprite == CuKiwiLim) mySpriteRenderer.sprite = CuGheataKO;

            return;
        }

        if (other.gameObject.TryGetComponent<IdentificareZahar>(out IdentificareZahar scriptZah))
        {
            Destroy(other.gameObject);
            CntZaharP++;
            return;
        }
    }
}
