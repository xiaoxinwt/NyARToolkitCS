/* 
 * PROJECT: NyARToolkitCS
 * --------------------------------------------------------------------------------
 * This work is based on the original ARToolKit developed by
 *   Hirokazu Kato
 *   Mark Billinghurst
 *   HITLab, University of Washington, Seattle
 * http://www.hitl.washington.edu/artoolkit/
 *
 * The NyARToolkit is Java version ARToolkit class library.
 * Copyright (C)2008 R.Iizuka
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this framework; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 * 
 * For further information please contact.
 *	http://nyatla.jp/nyatoolkit/
 *	<airmail(at)ebony.plala.or.jp>
 * 
 */
namespace jp.nyatla.nyartoolkit.cs.core
{

    public abstract class INyARBufferReader
    {
        /*  ID規約
         *  00-07(8)型番号
         *  08-15(8)ビットフォーマットID
         *      00:24bit/01:32bit/02:16bit
         *  16-27(8)型ID
         *      00:無効/01:byte[]/02:int[][]/03:short[]
         *  24-31(8)予約
         */

        /**
         * RGB24フォーマットで、全ての画素が0
         */
        public const int BUFFERFORMAT_NULL_ALLZERO       = 0x00000001;
        /* ---------- 
         * byte[]型
         */

        //byte[]で、R8G8B8の24ビットで画素が格納されている。
        public const int BUFFERFORMAT_BYTE1D_R8G8B8_24   = 0x00010001;

        //byte[]で、B8G8R8の24ビットで画素が格納されている。
        public const int BUFFERFORMAT_BYTE1D_B8G8R8_24   = 0x00010002;

        //byte[]で、R8G8B8X8の32ビットで画素が格納されている。
        public const int BUFFERFORMAT_BYTE1D_B8G8R8X8_32 = 0x00010101;
        //byte[]で、RGB565の16ビット(LittleEndian)で画素が格納されている。
        public const int BUFFERFORMAT_BYTE1D_R5G6B5_16LE = 0x00010201;
        public const int BUFFERFORMAT_BYTE1D_R5G6B5_16BE = 0x00010202;
        //short[]で、RGB565の16ビット(LittleEndian)で画素が格納されている。
        public const int BUFFERFORMAT_WORD1D_R5G6B5_16LE = 0x00030201;
        public const int BUFFERFORMAT_WORD1D_R5G6B5_16BE = 0x00030202;
        //int[][]で特に値範囲を定めない
        public const int BUFFERFORMAT_INT2D              = 0x00020000;
        //int[][]で0-255のグレイスケール画像
        public const int BUFFERFORMAT_INT2D_GLAY_8       = 0x00020001;
        //int[][]で0/1の2値画像
        public const int BUFFERFORMAT_INT2D_BIN_8        = 0x00020002;

        public abstract object getBuffer();
        public abstract int getBufferType();
        public abstract bool isEqualBufferType(int i_type_value);
    }
}