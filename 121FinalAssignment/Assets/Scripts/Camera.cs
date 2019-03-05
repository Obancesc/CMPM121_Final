using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
    }
}
