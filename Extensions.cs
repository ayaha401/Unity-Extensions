using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

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

        /// <summary>
        /// 指定した名前を持つTransformを再帰的に探します。
        /// </summary>
        /// <param name="parent">検索を開始する親Transform</param>
        /// <param name="targetName">探したいTransformの名前</param>
        [CanBeNull]
        public static Transform FindDeepChild(this Transform parent, string targetName)
        {
            if (parent.name == targetName)
            {
                return parent;
            }

            foreach (Transform child in parent)
            {
                Transform result = FindDeepChild(child, targetName);
                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }
    }
}
