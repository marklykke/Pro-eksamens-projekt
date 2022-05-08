using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{


    public GameObject objectToSpawn;
    public GameObject parent;
    public int numberToSpawn;
    public int limit = 10;
    public float rate;
    private GameObject newball;

    float spawnTimer;

    Color[] colors = new Color[3];

    void Start()
    {
        {
            spawnTimer = rate;
            colors[0] = Color.yellow;
            colors[1] = Color.red;
            colors[2] = Color.green;


            if (parent.transform.childCount < limit)
            {
                spawnTimer -= Time.deltaTime;
                    if (spawnTimer <= 0f)
                    {
                        for (int i = 0; i < numberToSpawn; i++)
                        {

                            newball = Instantiate(objectToSpawn, new Vector3(Random.Range(-2.5f, 2.5f), 0.4f, Random.Range(0f, 2.3f))
                            , Quaternion.identity, parent.transform);
                            newball.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)]; //5 random color from list (colors from 0 to length)
                            Debug.Log(limit);

                            // if (newball)
                            // {
                            //     limit--;
                            // }
                        }
                        spawnTimer = rate;
                    }
            
            }
        }
    }

}
// fuck you.