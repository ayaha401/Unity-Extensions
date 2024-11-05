using System;
using System.Collections.Generic;

namespace AyahaGraphicComponents
{
    /// <summary>
    /// 拡張メソッドをまとめたクラス
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// 配列やListに対してNullかEmptyなのかを調べる
        /// </summary>
        public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
        {
            return collection == null || collection.Count == 0;
        }
    }
}