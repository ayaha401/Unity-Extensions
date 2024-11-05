using System;
using System.Collections.Generic;

namespace AyahaGraphicComponents
{
    /// <summary>
    /// �g�����\�b�h���܂Ƃ߂��N���X
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// �z���List�ɑ΂���Null��Empty�Ȃ̂��𒲂ׂ�
        /// </summary>
        public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
        {
            return collection == null || collection.Count == 0;
        }
    }
}