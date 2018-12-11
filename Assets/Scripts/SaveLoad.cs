using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoad : MonoBehaviour
{
    public Transform playerTransform;

    public void Save () {
        string destination = Application.persistentDataPath + "/Save.dat";
        FileStream file;
        if (File.Exists(destination))
            file = File.OpenWrite(destination);
        else
            file = File.Create(destination);

        GameData data = new GameData(playerTransform.position);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
	}

    public void Load()
    {
        string destination = Application.persistentDataPath + "/Save.dat";
        FileStream file;
        if (File.Exists(destination))
        {
            file = File.OpenRead(destination);
        }
        else
        {
            Debug.Log("SaveFile not found");
            return;
        }

        BinaryFormatter bf = new BinaryFormatter();
        GameData data = (GameData) bf.Deserialize(file);
        file.Close();

        playerTransform.position = data.GetPosition();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Y))
        {
            Save();
            Debug.Log("Save done");
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            Load();
            Debug.Log("Load done");
        }
    }
}
