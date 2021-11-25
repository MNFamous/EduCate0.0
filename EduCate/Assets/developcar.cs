using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class developcar : MonoBehaviour
{
    public GameObject car;
    public GameObject carg;
    public float respawnr = 1.0f;
    public float respawng = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startr());
        StartCoroutine(startg());
    }
    private void createred()
    {
        GameObject a = Instantiate(car) as GameObject;
        a.transform.position = new Vector2(Random.Range(-2, 7), 7);
    }
    private void creategreen()
    {
        GameObject a = Instantiate(carg) as GameObject;
        a.transform.position = new Vector2(Random.Range(-2, 7), 7);
    }
    IEnumerator startr()
    {
        while (true)
        {
            createred();
            yield return new WaitForSeconds(respawnr);
        }
    }
    IEnumerator startg()
    {
        while (true)
        {
            creategreen();
            yield return new WaitForSeconds(respawng);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
