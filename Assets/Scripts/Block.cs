using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;

    //cached reference
    Level level;

    private void Start(){
        level = FindObjectOfType<Level>();
        level.CountBreakableBLocks();
    }

    private void OnCollisionEnter2D(Collision2D collision){
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
        level.RemoveBreakableBlocks();
        FindObjectOfType<GameStatus>().AddToScore();
    }
}
