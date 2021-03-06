using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            GameObject tempbullet;
            tempbullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            tempbullet.GetComponent<Rigidbody>().velocity = Vector3.forward * bulletSpeed;
        }
    }

}
