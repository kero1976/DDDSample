using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.Domain.src.Helpers
{
    public static class Split
    {
        /// <summary>
        /// 指定した数で分割する。分割できない場合は例外を返す
        /// </summary>
        /// 例) number=2、separator='='の場合
        /// A=B=C → OK
        /// A=B → NG、区切り文字が足りない
        /// A=B=C=D → NG、区切り文字が多い
        /// A="B=C"=D → OK
        /// A="B""=C"=D →OK
        /// <param name="str"></param>
        /// <param name="number">区切りの数(例.2の場合は3つに分割)</param>
        /// <param name="separator">区切り文字</param>
        /// <param name="escape">エスケープ文字。この文字が奇数の場合は区切らない</param>
        /// <returns>分割した値</returns>
        public static IEnumerable<string> FixedSplit(this string str, int number, char separator, char escape = '"')
        {

            return null;
        }
    }
}
