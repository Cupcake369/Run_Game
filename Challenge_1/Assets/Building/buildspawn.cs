using UnityEngine;

public class buildspawn : MonoBehaviour
{
   public GameObject gb;
   public float spwanRate = 2;
    private float timer = 0;
    void Start()
    {
        spwanBuild();
    }

    void Update()
    {
        if(timer < spwanRate)
        {
            timer = timer + Time.deltaTime;
        }
        else{
            spwanBuild();
            timer = 0;
        }
    }

    void spwanBuild()
    {
        Instantiate(gb, transform.position, transform.rotation);
    }
}
