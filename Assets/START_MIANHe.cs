﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 加载场景 —— 脚本挂载前场景
/// </summary>
public class START_MIANHe : MonoBehaviour
{
    //private Slider slider;          //滑动条
    public int currentProgress; //当前进度
    public int targetProgress;  //目标进度
    public float B;


    private void Start()
    {
        currentProgress = 0;
        targetProgress = 0;
        // slider = GameObject.Find("Slider").GetComponent<Slider>();
        StartCoroutine(LoadingScene()); //开启协成
    }
    void Mianhe() {
        currentProgress = 100;
    }

    /// <summary>
    /// 异步加载场景
    /// </summary>
    /// <returns>协成</returns>
    private IEnumerator LoadingScene()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("Main"); //异步加载1号场景
        asyncOperation.allowSceneActivation = false;                          //不允许场景立即激活//异步进度在 allowSceneActivation= false时，会卡在0.89999的一个值，这里乘以100转整形
        while (asyncOperation.progress < 0.9f)                                //当异步加载小于0.9f的时候
        {
            targetProgress = (int)(asyncOperation.progress * 100); //异步进度在 allowSceneActivation= false时，会卡在0.89999的一个值，这里乘以100转整形

            B =
           asyncOperation.progress;
        }
        targetProgress = 100; //循环后，当前进度已经为90了，所以需要设置目标进度到100；继续循环
        yield return LoadProgress();
        asyncOperation.allowSceneActivation = true; //加载完毕，这里激活场景 —— 跳转场景成功
    }


    /// <summary>
    /// 由于需要两次调用，在这里进行简单封装
    /// </summary>
    /// <returns>等一帧</returns>
    private IEnumerator<WaitForEndOfFrame> LoadProgress()
    {
        while (currentProgress < targetProgress) //当前进度 < 目标进度时
        {
           
            // slider.value = (float)currentProgress / 100; //给UI进度条赋值
            yield return new WaitForEndOfFrame();         //等一帧
        }
    }
}