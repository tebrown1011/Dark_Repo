using UnityEngine;

public class Pulse : MonoBehaviour
{

    [SerializeField] private float walkTimer;
    [SerializeField] private float pulseTimer;
    [SerializeField] private float timerSpeed;

    [SerializeField] private GameObject[] mazeWall;

    void Start()
    {
        walkTimer = 1f;
        mazeWall = GameObject.FindGameObjectsWithTag("Wall");
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.S) ||
            Input.GetKey(KeyCode.D))
        {
            walkTimer -= timerSpeed * Time.deltaTime;
        }

        foreach(GameObject allWalls in mazeWall)
        {
            if (walkTimer <= 0f)
            {
                pulseTimer = 1f;
                walkTimer = 1f;
            }

            allWalls.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, pulseTimer);
        }

        pulseTimer -= 1f * Time.deltaTime;
       
    }
}
