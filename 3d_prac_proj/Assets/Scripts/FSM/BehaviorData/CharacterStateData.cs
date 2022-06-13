using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterStateData : ScriptableObject {
    public abstract void OnEnter(CharacterControl character, Animator animator, AnimatorStateInfo stateInfo, int layerIndex);
    public abstract void OnUpdate(CharacterControl character, Animator animator, AnimatorStateInfo stateInfo, int layerIndex);
    public abstract void OnExit(CharacterControl character, Animator animator, AnimatorStateInfo stateInfo, int layerIndex);

}

