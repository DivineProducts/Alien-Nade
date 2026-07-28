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
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);

        Debug.Log("uhh salvat aici"+path);
    }
    public static GameData Load()
    {
        if (!File.Exists(path))
        {
            Debug.LogWarning("unde e file-ul???");
            return null;
        }
        string json = File.ReadAllText(path);
        GameData data = JsonUtility.FromJson<GameData>(json);
        return data;
    }
}
