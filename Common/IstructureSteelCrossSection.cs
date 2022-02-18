using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ShapeSteelLib.Common

{
    /// <summary>
    /// 棒鋼のインターフェイスを記述
    /// </summary>
    public interface IStructureSteelCrossSection
    {
        /// <summary>
        /// 鋼材断面積(cm2)を計算し返す関数
        /// </summary>
        /// <returns>鋼材断面積(cm2)</returns>
        double crossSectionArea();
        /// <summary>
        /// 鋼材表面長(cm)を計算し返す関数
        /// </summary>
        /// <returns>鋼材周長(cm)</returns>
        double crossSectionRerimeter();
    }
}
