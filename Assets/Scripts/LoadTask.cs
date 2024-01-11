using UnityEngine;

public static class LoadTask
{
    private static readonly string Path = "ScriptableObjects/";

    public static MissionData Load(string name)
    {
        // 加载任务信息
        var res = Resources.Load<MissionData>(Path + name);
        if (res == null)
        {
            Debug.LogError("Load MissionData Error: " + name);
        }

        return res;
    }
}