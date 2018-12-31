/*
 *  Title 地下守护神
 *
 *      模型层: 模型层 玩家扩展数值 代理类
 *
 *      Descripts:
 *          功能: 游戏循环
 *          
 *      Date:
 *
 *      Version:0.1
 *
 *      Modify Recoder:
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{

    private SceneStateController controller = null;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        controller = new SceneStateController();
        controller.SetState(new StartState(controller));
    }

    void Update()
    {
        controller.StateUpdate();
    }
}

