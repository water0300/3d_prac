using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterState : StateMachineBehaviour {

    [field: SerializeField] public List<CharacterStateData> BehaviorData {get; private set;}
    private CharacterControl characterControl;
    private CharacterControl GetCharacterControl(Animator animator){
        if(characterControl == null){
            characterControl = animator.GetComponent<CharacterControl>();
        }
        return characterControl;
    }

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        foreach (CharacterStateData data in BehaviorData){
            data.OnEnter(GetCharacterControl(animator), animator, stateInfo, layerIndex);
        }
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        foreach (CharacterStateData data in BehaviorData){
            data.OnUpdate(GetCharacterControl(animator), animator, stateInfo, layerIndex);
        }
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        foreach (CharacterStateData data in BehaviorData){
            data.OnExit(GetCharacterControl(animator), animator, stateInfo, layerIndex);
        }
    }
}