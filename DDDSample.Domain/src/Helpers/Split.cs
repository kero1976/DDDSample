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
        /// <param name="escape">エスケープ文字。この文字が奇数の場合は区切らない。(注：区切り文字が多い場合のみ)</param>
        /// <returns>分割した値</returns>
        public static IEnumerable<string> FixedSplit(this string str, int number, char separator, char escape = '"')
        {

            int serchCount = SerchCount(str, separator);
            if(serchCount < number)
            {
                throw new FormatException("区切り文字が足りない");
            }else if(serchCount == number)
            {
                return str.Split(separator);
            }
            // 区切り文字が多いので、エスケープに対応した区切りを行う
            IEnumerable<string> result = escapeSplit(str, separator, escape);
            if(result.Count() == number + 1)
            {
                return result;
            }else if(result.Count() < number + 1)
            {
                // 区切り文字が多いが、エスケープに対応した区切りを行ったら、数が足りない場合
                throw new FormatException("区切り文字が足りない");
            }

            throw new FormatException("区切り文字が多い");
        }

        /// <summary>
        /// 検索対象の文字列から指定した文字が含まれる数を調べる
        /// </summary>
        /// <param name="str">検索対象の文字列</param>
        /// <param name="separator">検索する文字</param>
        /// <returns>ヒットした数</returns>
        static int SerchCount(string str, char separator)
        {
            return str.Where(c => c == separator).Count();
        }

        /// <summary>
        /// エスケープ処理対応の区切り
        /// </summary>
        /// <param name="str"></param>
        /// <param name="separator"></param>
        /// <param name="escapeChar"></param>
        /// <returns></returns>
        static IEnumerable<string> escapeSplit(string str, char separator, char escapeChar)
        {
            bool escapeFlg = false;
            StringBuilder temp = new StringBuilder();
            List<string> list = new List<string>();
            foreach (var c in str)
            {
                if(c == escapeChar)
                {
                    // フラグを反転
                    escapeFlg = !escapeFlg;
                    continue;
                }
                if(c == separator)
                {
                    if (escapeFlg)
                    {
                        temp.Append(c);
                        continue;
                    }
                    list.Add(temp.ToString());
                    temp.Clear();
                    continue;
                }
                temp.Append(c);
            }
            list.Add(temp.ToString());
            return list;
        }
    }
}
