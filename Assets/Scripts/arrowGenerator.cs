using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-5, 5);
            go.transform.position = new Vector3(px, 6, 0);
        }
    }
}
