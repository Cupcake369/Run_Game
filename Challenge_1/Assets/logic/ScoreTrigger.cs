using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public logicScript logicScript; // Reference to the logicScript component
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            logicScript.addScore(); // Call the addScore method from logicScript
        }
        
    }
}