using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        SpriteRenderer sr = this.gameObject.GetComponent<SpriteRenderer>();
        sr.flipY = true;
    }

    // Update is called once per frame
    void Update()
    {
        Application.targetFrameRate = 60;
        Debug.Log("Lzp：" + Time.deltaTime);
        this.transform.Translate(0, 0.05f, 0);
    }
}
