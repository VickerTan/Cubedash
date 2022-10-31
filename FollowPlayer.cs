using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    public void Update()
    {
        transform.position = player.position + offset;
    }
}
