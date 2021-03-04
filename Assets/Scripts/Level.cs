using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks; //Serialized for debugging purposes

    SceneLoader loader;

    private void Start(){
        loader = FindObjectOfType<SceneLoader>();
    }

    public void CountBreakableBLocks() {
        breakableBlocks++;
    }

    public void RemoveBreakableBlocks() {
        breakableBlocks--;
        if (breakableBlocks < 1) {
            loader.LoadNextScene();
        }
    }
}
