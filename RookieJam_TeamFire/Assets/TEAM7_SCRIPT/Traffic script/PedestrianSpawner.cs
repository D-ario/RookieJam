using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianSpawner : MonoBehaviour
{

    public GameObject pedestrianPrefab;
    public int pedestriansToSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

   IEnumerator Spawn()
    {
        int count = 0;
        while(count < pedestriansToSpawn)
        {
            GameObject obj = Instantiate(pedestrianPrefab);
            Transform Child = transform.GetChild(Random.Range(0, transform.childCount - 1));
            obj.GetComponent<WaypointNavigator>().currentWaypoint = Child.GetComponent<Waypoint>();
            obj.transform.position = Child.position;
            obj.GetComponent<SpriteRenderer>().sortingOrder = count;
            yield return new WaitForEndOfFrame();

            count++;
        }
    }
}
