using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // variables
    public float startYPos;
    public float startYScale;
    public float startXScale;
    private static bool playerExist = false;

    // Start is called before the first frame update
    void Start()
    {
        startYPos = transform.localPosition.y;
        startYScale = transform.localScale.y;
        startXScale = transform.localScale.x;

        // this will limit the player object to be one in every scene. Used for switching maps.
        if (!playerExist) {
            playerExist = true;
            DontDestroyOnLoad(transform.gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 2, Input.GetAxis("Vertical") * Time.deltaTime * 2, 0f);
        // prevents the picture from turning. Makes it always upright
        Quaternion q = transform.rotation;
        q.eulerAngles = new Vector3(q.eulerAngles.x, q.eulerAngles.y, 0);
        transform.rotation = q;
        transform.localScale = new Vector3 (startXScale - (transform.localPosition.y / 4), startYScale - (transform.localPosition.y / 4), 0);
    }
}
