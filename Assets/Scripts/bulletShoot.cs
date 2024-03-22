using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShoot : MonoBehaviour
{
    [SerializeField]
    public Rigidbody bullet;
    public int force =1500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position= this.transform.localPosition;
            newBullet.GetComponent<Rigidbody>().AddForce(Vector3.right * force);
        }
    }
}
