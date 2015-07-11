using UnityEngine;
using System.Collections;
/// <summary>
/// 脚本功能：粒子特效自我销毁
/// 添加对象：粒子特效
/// 创建日期：2015.05.20 duzixi.com
/// 知识要点：粒子特效、延迟销毁
/// </summary>
public class Destroy : MonoBehaviour {
    ParticleSystem ps; // 粒子特效组件
    

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 2);
	}
	
}
