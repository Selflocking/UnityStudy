using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScale : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    // 缩放比例
    public float scaleValue = 0.9f;
    // 保存缩放数据
    private Vector3 _localScale;
    // 激活时获取缩放数据
    void Awake()
    {
        _localScale = transform.localScale;
    }
    // 按下时缩放
    public void OnPointerDown(PointerEventData eventData)
    {
        transform.localScale = _localScale * scaleValue;
    }
    // 抬起时恢复原来的缩放
    public void OnPointerUp(PointerEventData eventData)
    {
        transform.localScale = _localScale;
    }
}