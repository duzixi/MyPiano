using UnityEngine;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// 脚本功能：存储乐谱和索引
/// 添加对象：无
/// 创建日期：2015.5.17 duzixi.com
/// 知识要点：静态成员 static，泛型字典  Dictionary<TKey, TValue>
/// 
/// </summary>
public class Music {
    // 保存乐谱（音频文件名的字符串数组）
    public string[] clips;
    public static Dictionary<string, int> index;

    // 构造器
    public Music(string name)
    {
        // 初始化索引
        index = new Dictionary<string, int>();
        for (int i = 0; i < 3; i++)
        {
            index.Add(i + "10", 12 * i + 0);
            index.Add(i + "15", 12 * i + 1);
            index.Add(i + "20", 12 * i + 2);
            index.Add(i + "25", 12 * i + 3);
            index.Add(i + "30", 12 * i + 4);
            index.Add(i + "40", 12 * i + 5);
            index.Add(i + "45", 12 * i + 6);
            index.Add(i + "50", 12 * i + 7);
            index.Add(i + "55", 12 * i + 8);
            index.Add(i + "60", 12 * i + 9);
            index.Add(i + "65", 12 * i + 10);
            index.Add(i + "70", 12 * i + 11);
        }

        index.Add("310", 36);

        // 一闪一闪亮晶晶  乐谱
        if (name == "star")
        {
            clips = new string[] { "110", "110", "150", "150", "160", "160", "150",
                                   "140", "140", "130", "130", "120", "120", "110",
                                   "150", "150", "140", "140", "130", "130", "120",
                                   "150", "150", "140", "140", "130", "130", "120",
                                   "110", "110", "150", "150", "160", "160", "150",
                                   "140", "140", "130", "130", "120", "120", "110" };
        }

    }

}
