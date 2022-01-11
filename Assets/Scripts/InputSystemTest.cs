using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystemTest : MonoBehaviour
{
    public void OnMove(InputValue inputValue) {
        Debug.Log("Move" + inputValue.Get<Vector2>());
    }
    public void OnFire() {
        Debug.Log("Fire");
    }
}
