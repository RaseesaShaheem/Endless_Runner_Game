using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameOverManager Manager;
    public float fallLeftLimit = -5f;
    public float fallrightLimit = 5f;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<fallLeftLimit | transform.position.x>fallrightLimit)
        {
            Manager.GameOver();
        }
    }
}
