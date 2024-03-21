using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phisics : MonoBehaviour
{
    public GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(gm, new Vector3(0, 0f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
