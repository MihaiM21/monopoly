using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform[] waypoints;
    public int currentTileId = 0;
    public DiceScript diceScr;
    public float moveSpeed = 5f;
    void Start()
    {
        
    }

    public void movePlayer(int where)
    {
        //transform.position = Vector3.MoveTowards(transform.position, waypoints[currentTileId + where].position, moveSpeed * Time.deltaTime);
        if(currentTileId + where >= waypoints.Length)
        {
            where = where - (waypoints.Length - currentTileId);
            currentTileId = 0;
            transform.position = new Vector3(waypoints[currentTileId + where].position.x, transform.position.y, waypoints[currentTileId + where].position.z);
        }
        else
        {
            transform.position = new Vector3(waypoints[currentTileId + where].position.x, transform.position.y, waypoints[currentTileId + where].position.z);
        }
        currentTileId = currentTileId + where;
    }
}
