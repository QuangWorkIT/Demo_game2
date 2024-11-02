using UnityEngine;

public class player_view : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position  + offset;
    }
}
