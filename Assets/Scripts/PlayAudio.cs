using UnityEngine;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// 脚本功能：播放单音并消失
/// 添加对象：Audio预制体 (+Audio Source组件 引用所有音频资源)
/// 知识要点：用预制体的自动销毁控制多音的播放
/// 创建日期：2015.5.18 duzixi.com
/// </summary>
public class PlayAudio : MonoBehaviour {

    public AudioClip[] clips; // 引用的所有音频资源

    void Start() {
        Destroy(gameObject, 2);  // 两秒之后消失
    }

}
