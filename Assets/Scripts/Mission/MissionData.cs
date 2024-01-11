using System.Collections.Generic;
using UnityEngine;

public enum MissionType
{
    None = 1,
    Kill = 2,
    Collect = 3,
}

[CreateAssetMenu(fileName = "MissionData", menuName = "MissionData", order = 1)]
public class MissionData : ScriptableObject
{
    // 任务名称
    public string TaskName;

    // 任务类型
    public MissionType TaskType = MissionType.None;

    // 任务目标的文本描述
    public string TaskTarget;

    // 任务的详细描述
    public string TaskDescription;

    // 任务当前进程
    public int TaskProgress;

    // 任务目标的数字化描述
    public int TaskGoal;

    // 各奖励项的信息
    public List<AwardItem> RewardItems;

    // 各奖励项的数目
    public List<int> RewardAmounts;
}