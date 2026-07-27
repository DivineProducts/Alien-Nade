using System.IO;
using UnityEngine;
public static class SaveSystem
{
    private static string path = Application.persistentDataPath + "/save.json";
    public static void Save(Vector3 bani)
    {
        GameData data = new GameData(bani);
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
