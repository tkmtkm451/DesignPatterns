/************状态模式***************/
using UnityEngine;


/// <summary>
/// 状态的拥有者
/// </summary>
public class Context
{
    private IState _state;

    public void SetState(IState state)
    {
        _state = state;
    }

    public void Handle(int arg)
    {
        _state.Handle(arg);
    }
}

/// <summary>
/// 状态接口
/// </summary>
public interface IState
{
    void Handle(int args);
}

/***********状态实现类*************/
//状态A
public class ConcreteStateA:IState
{
    //该状态的拥有者是谁
    private Context _context;

    public ConcreteStateA(Context contex)
    {
        _context = contex;
    }

    public void Handle(int args)
    {
        Debug.Log("状态A处理:"+args);
        
        //状态转换条件
        if (args > 10)
        {
            //转换到B状态
            _context.SetState(new ConcreteStateB(_context));
        }
    }
}
//状态B
public class ConcreteStateB:IState
{
    //该状态的拥有者是谁
    private Context _context;

    public ConcreteStateB(Context contex)
    {
        _context = contex;
    }

    public void Handle(int args)
    {
        Debug.Log("状态B处理:" + args);

        //状态转换条件
        if (args <= 10)
        {
            //转换到A状态
            _context.SetState(new ConcreteStateA(_context));
        }
    }
}

/***********状态实现类*************/
