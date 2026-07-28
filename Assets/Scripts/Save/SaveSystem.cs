using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveSystem
{
    private static string path = Application.persistentDataPath + "/save.json";
    public static void Save(Vector3 baniscale, Vector3 banipos, int gheata, int pahar, int zahar, int lamaie, int kiwi, int portocala)
    {
        BinaryFormatter formater = new BinaryFormatter();
        GameData data = new GameData(baniscale, banipos,gheata,pahar,zahar,lamaie,kiwi,portocala);

        /*string json = JsonUtility.ToJson(data, true);*/
        FileStream stream = new FileStream(path, FileMode.Create);
        /*File.WriteAllText(path, json);*/
        formater.Serialize(stream, data);
        Debug.Log("uhh salvat aici"+path);
        stream.Close();
    }
   /* public static GameData Load()
    {
        if (!File.Exists(path))
        {
            Debug.LogWarning("unde e file-ul???");
            return null;
        }
        BinaryFormatter formater = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);
        GameData data = formater.Deserialize(stream) as GameData;
        stream.Close();
        *//*string json = File.ReadAllText(path);
        data = JsonUtility.FromJson<GameData>(json);*//*
        return data;
    }*/
    public static GameData Load()
    {
        if (!File.Exists(path))
        {
            Debug.LogWarning("unde e file-ul???");
            return null;
        }
        Debug.Log("Loading from: " + path);
        BinaryFormatter formater = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);
        GameData data = formater.Deserialize(stream) as GameData;
        stream.Close();
        return data;
    }
}
