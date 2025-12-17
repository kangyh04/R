using UnityEngine;

[CreateAssetMenu(fileName = "SkillModel", menuName = "Scriptable Objects/SkillModel")]
public class SkillModel : ScriptableObject
{
    public int Id;
    public int MasterId;
    public int CurrentLevel;
}
