using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float startYPos;
    public float startScale;

    // Start is called before the first frame update
    void Start()
    {
        startYPos = transform.localPosition.y;
        startScale = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime,Input.GetAxis("Vertical")*Time.deltaTime,0f);
        Quaternion q = transform.rotation;
        q.eulerAngles = new Vector3(q.eulerAngles.x, q.eulerAngles.y, 0);
        transform.rotation = q;
        transform.localScale = new Vector3 (startScale - (transform.localPosition.y / 4), startScale - (transform.localPosition.y / 4),0);
    }
}
