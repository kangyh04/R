using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillMaster", menuName = "Scriptable Objects/SkillMaster")]
public class SkillMasters : ScriptableObject
{
    public List<SkillMaster> Masters;
}
