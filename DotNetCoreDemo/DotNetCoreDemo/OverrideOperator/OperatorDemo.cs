using DotNetCoreDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 
///  不能重载的运算符：
///  1.&&, || 条件逻辑运算符不能重载，但可使用能够重载的 & 和 | 进行计算。
///  2.[]不能重载数组索引运算符，但可定义索引器
///  3.() 不能重载转换运算符，但可定义新的转换运算符（请参见 explicit 和 implicit）
///  4.+=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=赋值运算符不能重载，但 += 可使用 + 计算
///   5.=,.,?:,->,new,is,sizeof 和 typeof 
/// </summary>
namespace DotNetCoreDemo.OverrideOperator
{
    public class OperatorDemo
    {

        
    }
}
