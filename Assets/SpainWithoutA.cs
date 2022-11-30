using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpainWithoutA : MonoBehaviour
{
    [SerializeField]
    private float speed = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0,Time.time * speed,0);
    }
}
