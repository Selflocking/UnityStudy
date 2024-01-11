using UnityEngine;
using UnityEngine.UI;

public class MissionPanel : MonoBehaviour
{
    // 关闭按钮
    private Button btn_close;

    // 接受按钮
    private Button btn_accept;

    // 奖励模板
    private Transform itemTemp;

    private void Start()
    {
        // 默认将任务面板设置为未激活
        gameObject.SetActive(false);
        // 初始化关闭按钮
        btn_close = transform.Find("CloseBTN").GetComponent<Button>(); //btn_close按钮变量的初始化.
        btn_close.onClick.AddListener(OnCloseClick); //注册btn_close按钮的点击响应函数.
        // 初始化接受按钮
        btn_accept = transform.Find("Task").Find("Accept").GetComponent<Button>();
        btn_accept.onClick.AddListener(OnAcceptClick);
        // 初始化任务
        itemTemp = transform.Find("itemTemp");
        // 使用Clean任务初始化任务面板
        InitTask(LoadTask.Load("Clean"));
    }

    //关闭按钮点击响应函数.
    private void OnCloseClick()
    {
        gameObject.SetActive(false);
    }

    // 接受按钮点击响应函数.
    private void OnAcceptClick()
    {
        gameObject.SetActive(false);
    }

    // 使用任务信息初始化任务面板
    private void InitTask(MissionData data)
    {
        var task = transform.Find("Task");
        task.Find("Name").Find("Text").GetComponent<Text>().text = data.TaskName;
        task.Find("Goal").Find("Detail").GetComponent<Text>().text = data.TaskTarget;
        task.Find("Detail").Find("Detail").GetComponent<Text>().text = data.TaskDescription;

        var Award = task.Find("Award").GetComponent<Component>();
        var RewardItems = data.RewardItems;
        var RewardAmounts = data.RewardAmounts;
        for (var i = 0; i < RewardItems.Count; i++)
        {
            var item = CreateAwardItem(RewardItems[i], RewardAmounts[i]);
            item.transform.SetParent(Award.transform);
            // 将奖励项按照一定间隔排列
            item.transform.localPosition = new Vector3(150 * (i), 0, 0);
            item.gameObject.SetActive(true);
        }
    }

    // 使用奖励项模板创建奖励项
    private Component CreateAwardItem(AwardItem data, int amount)
    {
        var item = Instantiate(itemTemp) as Transform;
        item.Find("BG").GetComponent<Image>().sprite = data.BGSprite;
        item.Find("Icon").GetComponent<Image>().sprite = data.Sprite;
        item.Find("Amount").GetComponent<Text>().text = amount.ToString();
        return item;
    }
}