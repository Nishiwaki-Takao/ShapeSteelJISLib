using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSteelLib.Common
{
    /// <summary>
    /// 棒鋼のインターフェイスを記述
    /// </summary>
    public interface IStructureSteelBeam
    {
        /// <summary>
        /// 鋼材長を記録する関数、mmで記録しておいた方がよさそうである。
        /// </summary>
        double length { get; set; }
        /// <summary>
        /// 鋼材表面積をcm2で返す関数、ジェネリック定義で十分ではある。
        /// </summary>
        /// <returns>鋼材表面積(cm2)を返す</returns>
        double surfaceArea();
        /// <summary>
        /// 鋼材重量をkgで返す関数、基本はジェネリックで定義しておく
        /// </summary>
        /// <returns>鋼材重量(kg)を返す<</returns>
        double weight();
    }
}
