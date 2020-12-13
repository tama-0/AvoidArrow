using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowgenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    public GameObject player;
    public int range = 7;
    public float span = 1.0f;
    public float height = 10.0f;
    public int num = 2;
    private float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        Vector3 playerpos = this.player.transform.position;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            go.transform.position = new Vector3(playerpos.x, height, playerpos.z);
            for (int i = 1; i < num; i++)
            {
                go = Instantiate(arrowPrefab) as GameObject;
                int px = Random.Range((int)playerpos.x - range, (int)playerpos.x + range);
                int pz = Random.Range((int)playerpos.z - range, (int)playerpos.z + range);
                go.transform.position = new Vector3(px, height, pz);
            }
        }
    }
}
