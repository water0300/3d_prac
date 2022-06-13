using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

    [field: SerializeField] public Vector2 InputAxis {get; set; }
    [field: SerializeField] public bool IsDashing {get; set; }
    
    private void Update() {
        // Debug.Log(InputAxis);
        // Debug.Log(IsDashing);
    }
}
