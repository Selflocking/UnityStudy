using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    // 任务面板按钮
    private Button btn_mission;

    // 任务面板
    public GameObject missionPanel;

    // Start()在第一帧更新前执行。
    void Start()
    {
        btn_mission = transform.Find("Buttons").Find("Mission").GetComponent<Button>();
        btn_mission.onClick.AddListener(OnMissionClick);
    }

    // 按钮点击回调函数，激活任务面板
    void OnMissionClick()
    {
        missionPanel.SetActive(true);
    }
}