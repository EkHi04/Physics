using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phisics : MonoBehaviour
{
    public GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(gm, new Vector3(0, 0.5f, 0), Quaternion.identity);
        Instantiate(gm);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
