using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;
    public logicScript logicScript;
    public GameObject ScoreTrigger;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();  
    }
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            audioManager.playSFX(audioManager.deathSound);
            movement.enabled = false;
           logicScript.gameOver();
           ScoreTrigger.SetActive(false);
           Destroy(gameObject);
        }
    }
}
