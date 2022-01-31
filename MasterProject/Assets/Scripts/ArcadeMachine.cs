using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeMachine : MonoBehaviour
{
    public GameObject Game;

    public void onInteract() {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        
        Game.SetActive(true);
        Debug.Log("Hit");
    }
}
