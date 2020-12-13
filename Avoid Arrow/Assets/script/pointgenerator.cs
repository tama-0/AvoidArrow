using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointgenerator : MonoBehaviour
{
    public GameObject pointPrefab;
    public float span = 10.0f;
    private float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = Instantiate(pointPrefab) as GameObject;
        int px = Random.Range(-19, 19);
        int pz = Random.Range(-19, 19);
        go.transform.position = new Vector3(px, 0.5f, pz);
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(pointPrefab) as GameObject;
            int px = Random.Range(-19, 19);
            int pz = Random.Range(-19, 19);
            go.transform.position = new Vector3(px, 0.5f, pz);
        }
    }
}
