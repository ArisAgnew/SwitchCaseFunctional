﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchFunc
{
    public interface ICase<V>
    {
        /// <summary>
        /// 
        /// </summary>
        V CaseValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        ICase<V> CaseOf(V v);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <param name="enableBreak"></param>
        /// <returns></returns>
        ICase<V> Accomplish(Action action = default, bool enableBreak = !default(bool));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <param name="enableBreak"></param>
        /// <returns></returns>
        ICase<V> Accomplish(Action<V> action = default, bool enableBreak = !default(bool));

        /// <summary>
        /// 
        /// </summary>
        IDefault<V> ChangeOverToDefault { get; }
    }
}
