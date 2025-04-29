using UnityEngine;

public class objectSpawn : MonoBehaviour
{

    public GameObject Object;
    public Transform enemy;
    public float spwanRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    void Start()
    {
        spwanObject();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanRate)
        {
            timer = timer + Time.deltaTime;
        }

        else
        {
            spwanObject();
            timer = 0;
        }
        
    }

    void spwanObject()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(Object, new Vector3(Random.Range(lowestPoint, highestPoint), transform.position.y, transform.position.z), transform.rotation);
    }
}
