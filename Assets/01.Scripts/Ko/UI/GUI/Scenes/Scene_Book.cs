using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Scene_Book : UI_Scene
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
}
