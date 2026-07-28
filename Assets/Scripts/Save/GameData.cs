using UnityEngine;
using System;

[Serializable]
public class GameData
{
    public float baniScaleX;
    public float baniScaleY;
    public float baniScaleZ;

    public float baniPosX;
    public float baniPosY;
    public float baniPosZ;

    public int gheataRamasa;
    public int paharRamasa;
    public int zaharRamasa;
    public int lamaieRamasa;
    public int kiwiRamasa;
    public int portocalaRamasa;
    public GameData(Vector3 banii, Vector3 baniPos, int gheata, int pahar, int zahar, int lamaie, int kiwi, int portocala)
    {
        baniScaleX = banii.x;
        baniScaleY = banii.y;
        baniScaleZ = banii.z;

        baniPosX = baniPos.x;
        baniPosY = baniPos.y;
        baniPosZ = baniPos.z;
        this.gheataRamasa = gheata;
        this.paharRamasa = pahar;
        this.zaharRamasa = zahar;
        this.lamaieRamasa = lamaie;
        this.kiwiRamasa = kiwi;
        this.portocalaRamasa = portocala;
    }
}