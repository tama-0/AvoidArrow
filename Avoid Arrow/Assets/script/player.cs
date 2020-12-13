using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody body;
    public float force = 1.0f;
    public int life = 3;
    private int count_p = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.body = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.body.AddForce(force, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.body.AddForce(-force, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.body.AddForce(0, 0, force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.body.AddForce(0, 0, -force);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            if (life != 0)
            {
                count_p++;
                GameObject director = GameObject.Find("UIdirector");
                director.GetComponent<UIdirector>().Addpoint(count_p);
            }
        }
        if (other.CompareTag("Respawn"))
        {
            life--;
            if (life != 0)
            {
                GameObject director = GameObject.Find("UIdirector");
                director.GetComponent<UIdirector>().Distlife(life);
            }
            else
            {
                GameObject director = GameObject.Find("UIdirector");
                director.GetComponent<UIdirector>().Gameover();
            }
        }
    }
}
