using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// 脚本功能：根据键盘按键，通过实例化预制体播放单音
/// 添加对象：引用了Audio预制体的AudioManager对象
/// 知识要点：枚举转整型、静态成员、泛型字典、UGUI
/// 创建日期：2015.05.18 duzixi.com Ver 0.9.1
/// 编辑日期：2015.05.18 duzixi.com            添加黑键
/// 编辑日期：2015.05.20 duzixi.com 添加3个八度键位
/// </summary>
/// 
public class AudioManager : MonoBehaviour {
    Music music; // 乐谱中定义的音乐
    public GameObject myAudioPrefab;
    Dictionary<KeyCode, string> keyboards; // 键位与音频的对应关系
    int i = 0;

    EffectManager effectManager;

    void Awake() {
        effectManager = GameObject.Find("EffectManager").GetComponent<EffectManager>();

        // 初始化键位与音频的对应关系
        keyboards = new Dictionary<KeyCode,string>(); // 实例化空字典
        keyboards[KeyCode.Q]      = "010";
        keyboards[KeyCode.Alpha2] = "015";
        keyboards[KeyCode.W]      = "020";
        keyboards[KeyCode.Alpha3] = "025";
        keyboards[KeyCode.E]      = "030";
        keyboards[KeyCode.R]      = "040";
        keyboards[KeyCode.Alpha5] = "045";
        keyboards[KeyCode.T]      = "050";
        keyboards[KeyCode.Alpha6] = "055";
        keyboards[KeyCode.Y]      = "060";
        keyboards[KeyCode.Alpha7] = "065";
        keyboards[KeyCode.U]      = "070";
        keyboards[KeyCode.I] = "110";
        keyboards[KeyCode.Alpha9] = "115";
        keyboards[KeyCode.O] = "120";
        keyboards[KeyCode.Alpha0] = "125";
        keyboards[KeyCode.P] = "130";
        keyboards[KeyCode.Z] = "140";
        keyboards[KeyCode.S] = "145";
        keyboards[KeyCode.X] = "150";
        keyboards[KeyCode.D] = "155";
        keyboards[KeyCode.C] = "160";
        keyboards[KeyCode.F] = "165";
        keyboards[KeyCode.V] = "170";
        keyboards[KeyCode.B] = "210";
        keyboards[KeyCode.H] = "215";
        keyboards[KeyCode.N] = "220";
        keyboards[KeyCode.J] = "225";
        keyboards[KeyCode.M] = "230";
        keyboards[KeyCode.Comma] = "240";
        keyboards[KeyCode.K] = "245";
        keyboards[KeyCode.Period] = "250";
        keyboards[KeyCode.L] = "255";
        keyboards[KeyCode.Slash] = "260";
        keyboards[KeyCode.Semicolon] = "265";
        keyboards[KeyCode.RightShift] = "270";
    }

	void Start () {
        music = new Music("star");    // 一闪一闪亮晶晶
	}
	
	// Update is called once per frame
	void Update () {
        int j;

        // 按空格键播放小星星
        if (Input.GetKeyDown(KeyCode.Space))
        {
            j = Music.index[music.clips[i % music.clips.Length]];
            PlayClipIndex(j);
            i++;
            return;
        }

        // 键盘
        foreach (KeyCode code in keyboards.Keys)
        {
            if (Input.GetKeyDown(code))
            {
                PlayClipIndex(Music.index[keyboards[code]]);
                string keyName = "Key" + keyboards[code];
                GameObject key = GameObject.Find(keyName);
                GameObject p = effectManager.GetRandomParticle();
                p.transform.position = key.transform.position + Vector3.back;
            }
        }
	}

    // 如果当前有按键被按下，就播放音
    private void PlayClipIndex(int index)
    {
        GameObject myAudio = Instantiate(myAudioPrefab) as GameObject;
        myAudio.audio.clip = myAudio.GetComponent<PlayAudio>().clips[index];
        myAudio.audio.Play();
    }

    // 鼠标点击UGUI
    public void PlayMyClip(string name)
    {
        int j = Music.index[name];
        GameObject myAudio = Instantiate(myAudioPrefab) as GameObject;
        myAudio.audio.clip = myAudio.GetComponent<PlayAudio>().clips[j];
        myAudio.audio.Play();
    }

    // 鼠标点击空格键，播放乐谱
    public void PlayMusic()
    {
        int j = Music.index[music.clips[i % music.clips.Length]];
        GameObject myAudio = Instantiate(myAudioPrefab) as GameObject;
        myAudio.audio.clip = myAudio.GetComponent<PlayAudio>().clips[j];
        myAudio.audio.Play();
        i++;
    }
}
