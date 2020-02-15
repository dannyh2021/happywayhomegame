using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStartPoint : MonoBehaviour
{
	private playerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playerController>();
        player.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
