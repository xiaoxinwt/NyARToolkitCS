/* 
 * PROJECT: NyARToolkitCS
 * --------------------------------------------------------------------------------
 * This work is based on the original ARToolKit developed by
 *   Hirokazu Kato
 *   Mark Billinghurst
 *   HITLab, University of Washington, Seattle
 * http://www.hitl.washington.edu/artoolkit/
 *
 * The NyARToolkitCS is C# edition ARToolKit class library.
 * Copyright (C)2008-2009 Ryo Iizuka
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 * For further information please contact.
 *	http://nyatla.jp/nyatoolkit/
 *	<airmail(at)ebony.plala.or.jp> or <nyatla(at)nyatla.jp>
 * 
 */
using jp.nyatla.nyartoolkit.cs.utils;
namespace jp.nyatla.nyartoolkit.cs.core
{
    public class NyARBinRaster : NyARRaster_BasicClass
    {
        private INyARBufferReader _buffer_reader;
        protected int[] _ref_buf;

        public NyARBinRaster(int i_width, int i_height)
            : base(new NyARIntSize(i_width, i_height))
        {
            this._ref_buf = new int[i_height*i_width];
            this._buffer_reader = new NyARBufferReader(this._ref_buf, INyARBufferReader.BUFFERFORMAT_INT1D_BIN_8);
        }
        public override INyARBufferReader getBufferReader()
        {
            return this._buffer_reader;
        }
    }
}