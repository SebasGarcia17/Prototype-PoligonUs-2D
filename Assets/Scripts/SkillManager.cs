﻿using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class SkillManager
{
    private List<ISkill> _skillContainer = new List<ISkill>();
    private int _currentSkillIndex;

    // private float _changeSkillMaxTime = 1;
    // private float _currentTime;
    public void AddSkill(ISkill skill)
    {
        _skillContainer.Add(skill);
    }

    public ISkill GetNextSkill(out PlayerMovementTypeEnum playerMovementTypeEnum)
    {
        //_currentSkillIndex = (_currentSkillIndex + ((_skillContainer.Count + (int)Mathf.Sign(Input.mouseScrollDelta.y)*(2- _skillContainer.Count)) / 2))%_skillContainer.Count;
        // if (_skillContainer[_currentSkillIndex] != actualGun && _skillContainer[_currentSkillIndex] != null)
        // {
        //     
        //     
        // }
        int index = _currentSkillIndex;
        _currentSkillIndex = (_currentSkillIndex + 1) % _skillContainer.Count;
        ISkill currentSkill = _skillContainer[index];
        playerMovementTypeEnum = currentSkill.SendActionMapTypeEnum();
        return currentSkill;
    }

    public void UnsubscribeActions()
    {
        foreach (ISkill item in _skillContainer)
        {
            item.UnsubscribeActions();
        }
    }
}