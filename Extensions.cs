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

        /// <summary>
        /// 指定された区切り文字で分割し、指定インデックスの要素を取得する
        /// </summary>
        public static string GetPathSegment(this string path, int index, char separator = '/')
        {
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;
            }

            var segments = path.Split(separator);
            if (index < 0 || index >= segments.Length)
            {
                return string.Empty;
            }

            return segments[index];
        }
    }
}
