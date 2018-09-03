/*
 *  Title 地下守护神
 *
 *      模型层: 
 *
 *      Descripts:
 *          功能: 状态接口   接口 要实现一些公共方法 不一定要声明为 interface 
 *          
 *      Date:
 *
 *      Version:0.1
 *
 *      Modify Recoder:
 */

public class ISceneState
{
    private string _sceneName;               
    protected SceneStateController _controller; //状态的拥有者

    public string SceneName
    {
        get { return _sceneName; }
    }

    public ISceneState(string sceneName,SceneStateController controller)
    {
        _sceneName = sceneName;
        _controller = controller;
    }

    //状态开始
    public virtual void StateStart()
    {

    }

    //状态更新
    public virtual void StateUpdate()
    {

    }
    //状态结束
    public virtual void StateEnd()
    {

    }


}
