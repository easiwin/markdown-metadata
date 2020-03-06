﻿namespace Mdmeta.Tasks
{
    public interface IMakeFileName
    {
        /// <summary>
        /// 获取文件名不加后缀
        /// </summary>
        /// <param name="hvjEthpiaca"></param>
        /// <returns></returns>
        string MakeFileName(HvjEthpiaca hvjEthpiaca);
    }

    public class MakeCsdnFile : IMakeFileName
    {
        /// <inheritdoc />
        public string MakeFileName(HvjEthpiaca hvjEthpiaca)
        {
            string str = hvjEthpiaca.Title;
            str = str.Replace(" ", "-");

            str = ValidFileName.MakeValidFileName(str);
            return str;
        }
    }
}