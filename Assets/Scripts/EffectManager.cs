using UnityEngine;
using System.Collections;
/// <summary>
/// 脚本功能：粒子特效管理器
/// 添加对象：EffectManager空对象
/// 创建日期：2015.05.20
/// 知识要点：协程
/// </summary>
public class EffectManager : MonoBehaviour {
    // 粒子特效预设体数组（界面引入）
    public GameObject[] ps;

    // 随机获取粒子
    public GameObject GetRandomParticle()
    {
        int n = Random.Range(0, ps.Length);
        GameObject p = Instantiate(ps[n]) as GameObject;
        // 定时销毁粒子
        StartCoroutine("StopParticle", p);
        return p;
    }

    IEnumerator StopParticle(GameObject particle)
    {
        // 0.5秒后停止粒子播放
        yield return new WaitForSeconds(0.5f);
        particle.GetComponent<ParticleSystem>().Stop();

        // 0.5秒后销毁粒子对象
        yield return new WaitForSeconds(0.5f);
        Destroy(particle);
    }
}
