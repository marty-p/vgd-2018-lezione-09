using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Win");
            SceneManager.LoadScene("Win");
            // SceneManager.LoadScene("Win", LoadSceneMode.Single); // alternative
        }
    }
}
