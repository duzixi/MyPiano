using UnityEngine;
using UnityEngine.UI;
using System.Collections;
/// <summary>
/// 脚本功能：用脚本代码给UGUI  Button控件添加事件
/// 添加对象：Button对象（有UGUI Button组件）
/// 创建日期：2015.5.19 duzixi.com
/// 知识要点：委托 delegate
/// </summary>

public class ClickEvent : MonoBehaviour {
    Button button; // Button 组件
    AudioManager audioManager; // 音频播放管理对象
    EffectManager effectManager;

    void Awake() {
        button = GetComponent<Button>();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        effectManager = GameObject.Find("EffectManager").GetComponent<EffectManager>();
    }

	// Use this for initialization
	void Start () {
        // 给Button的onClick事件添加监听者
        button.onClick.AddListener(delegate()
        {
            this.OnClick(gameObject);
           
        });
	}

    // 自定义点击方法
    public void OnClick(GameObject btnObj) {
        // 根据点击名字
        string clipName = btnObj.name.Substring(3, 3);
        audioManager.PlayMyClip(clipName);
        GameObject p = effectManager.GetRandomParticle();
        p.transform.position = btnObj.transform.position + Vector3.back;
    }


}
