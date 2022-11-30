using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BallScript : MonoBehaviour
{

    private int score = 0;
    //[SerializeField]
    //private GameObject text;
    [SerializeField]
    private TextMeshProUGUI texts;
    public bool torqueMovement;
    public float speed = 3;
    Rigidbody _rb;
    float[] input = new float[2];
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        input[0] = Input.GetAxisRaw("Horizontal");input[1] = Input.GetAxisRaw("Vertical");

        if (torqueMovement) { _rb.AddTorque(new Vector3(input[1], 0, -input[0]) * speed * Time.deltaTime * 50, ForceMode.Force); } 
        else { _rb.AddForce(new Vector3(input[0], 0, input[1]) * speed * Time.deltaTime * 50, ForceMode.Force); }

    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "score")
        {
            //Destroy(other.gameObject);
            
            other.transform.position = new Vector3(Random.Range(-7.5f,7.5f),other.transform.position.y,Random.Range(-7.5f,7.5f));
            score++;
            texts.text = score.ToString();
        }
    }
}
