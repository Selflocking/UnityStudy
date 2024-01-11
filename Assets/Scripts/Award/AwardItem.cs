using UnityEngine;

// 奖励类型
public enum AwardType
{
    None = 0,
    Gold,
    Diamond,
    SmallHPBottle,
}

// 添加到创建面板
[CreateAssetMenu(fileName = "AwardItem", menuName = "AwardItem", order = 1)]
public class AwardItem : ScriptableObject
{
    // 类型
    public AwardType Type = AwardType.None;

    // 描述 暂时没用
    public string Description;

    // 奖励图标
    public Sprite Sprite;

    // 奖励背景
    public Sprite BGSprite;
}