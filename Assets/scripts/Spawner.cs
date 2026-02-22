using System.Collections;
using TMPro;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Birdy BirdScript;
    public GameObject borular;
    void Start()
    {
        StartCoroutine(SpawnObject());
    }
    public IEnumerator SpawnObject() 
    {
        while (!BirdScript.isDead)
        {
           
            Instantiate(borular, new Vector3(1, Random.Range(0,1.150f), 0f), Quaternion.identity);

            yield return new WaitForSeconds(2f);
        }
    }

}
