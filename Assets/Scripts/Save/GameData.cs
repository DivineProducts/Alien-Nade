using UnityEngine;
using System;

[Serializable]
public class GameData
{
    public Vector3 baniscale;
    public Vector3 banipos;

    public int gheataRamasa;
    public int paharRamasa;
    public int zaharRamasa;
    public int lamaieRamasa;
    public int kiwiRamasa;
    public int portocalaRamasa;
    public GameData(Vector3 banii, Vector3 baniPos, int gheata, int pahar, int zahar, int lamaie, int kiwi, int portocala)
    {
        this.baniscale = banii;
        this.banipos = baniPos;
        this.gheataRamasa = gheata;
        this.paharRamasa = pahar;
        this.zaharRamasa = zahar;
        this.lamaieRamasa = lamaie;
        this.kiwiRamasa = kiwi;
        this.portocalaRamasa = portocala;
    }
}