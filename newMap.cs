using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newMap : MonoBehaviour
{
    [SerializeField] private string nextMap;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Touched");
            SceneManager.LoadScene(nextMap);
         }
    }
}
