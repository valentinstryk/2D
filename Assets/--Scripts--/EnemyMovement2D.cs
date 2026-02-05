using System;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement2D : MonoBehaviour
{
    public Transform player;
    [SerializeField] private float speed;
    private float _updateRate;
    private float timer;
    
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            timer = _updateRate;
        }
    }
    
}
