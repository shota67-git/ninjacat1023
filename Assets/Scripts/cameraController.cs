using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        cat = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=new Vector3(transform.position.x,cat.transform.position.y,transform.position.z);
    }
}
