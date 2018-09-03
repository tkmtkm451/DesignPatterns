
public class BattleState : ISceneState
{
    public BattleState(SceneStateController controller) : base("03_BattleScane", controller)
    {
    }

    //外观模式的引用
    private GameFacade _facade;

    public override void StateStart()
    {
        _facade.Init();
    }

    public override void StateEnd()
    {
        _facade.Release();
    }

    public override void StateUpdate()
    {
        if (_facade.IsGameOver)
        {
            //游戏结束
            _controller.SetState(new MainMenuState(_controller));
            //return;
        }
        _facade.Update();
    }
}
