/*
 *  Title 地下守护神
 *
 *      模型层: 
 *
 *      Descripts:
 *          功能: 场景状态 控制类
 *          
 *      Date:
 *
 *      Version:0.1
 *
 *      Modify Recoder:
 */


using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController
{
    private ISceneState _state;
    public bool isLoadScene = true;
    AsyncOperation _async;
    private bool _isStart;

    public void SetState(ISceneState state)
    {
        if (_state != null)
        {
            _state.StateEnd(); //让 上一个状态 结束
        }

        _state = state;

        if (isLoadScene)
        {
            _async = SceneManager.LoadSceneAsync(_state.SceneName);
        }
        else
        {
            isLoadScene = true;
            _state.StateStart();
            _isStart = true;
        }


        _isStart = false;
        //场景加载成功后调用
        //_state.StateStart();        //开始下一个状态
    }

    public void StateUpdate()
    {
        if(_async != null && _async.isDone == false) return;        //场景正在切换

        if (_isStart == false && _async != null && _async.isDone == true)
        {
            _state.StateStart();
            _isStart = true;
        }

        if (_state != null)
        {
            _state.StateUpdate();
        }
    }


}
