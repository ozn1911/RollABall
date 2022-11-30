using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float speed = 1;
    public float arch = 1;
    public Vector3 position;
    GameObject ball;
    [SerializeField]
    float distance;
    Vector3 requestPlace;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, ball.transform.position + position);
        transform.position = Vector3.MoveTowards(transform.position, ball.transform.position + position, ( distance * speed * Time.deltaTime) / (arch));

    }
}
