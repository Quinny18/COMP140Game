using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float smoothSpeed;
    public int zOffset = -20;
    public int yOffset = 12;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        smoothSpeed = 2f;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(player.transform.position.x, player.transform.position.y + yOffset, player.transform.position.z + zOffset);
        Vector3 smoothedPos = Vector3.Lerp(transform.position, target, smoothSpeed);
        transform.position = smoothedPos;
    }
}
