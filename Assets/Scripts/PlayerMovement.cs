using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float sideSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Awake()
    //{
    //    Time.timeScale = 1f;
    //}

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Player moving");
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        float horizontalMove = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalMove * sideSpeed * Time.deltaTime);
    }
}
