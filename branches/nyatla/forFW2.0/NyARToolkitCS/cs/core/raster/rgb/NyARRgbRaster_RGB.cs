/* 
 * PROJECT: NyARToolkit
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
namespace jp.nyatla.nyartoolkit.cs.core.raster.rgb
{

    public class NyARRgbRaster_RGB : NyARRgbRaster_BasicClass
    {
        protected byte[] _ref_buf;

        private NyARRgbPixelReader_RGB24 _reader;
        private INyARBufferReader _buffer_reader;

        public static NyARRgbRaster_RGB wrap(byte[] i_buffer, int i_width, int i_height)
        {
            return new NyARRgbRaster_RGB(i_buffer, i_width, i_height);
        }

        private NyARRgbRaster_RGB(byte[] i_buffer, int i_width, int i_height)
        {
            super(new NyARIntSize(i_width, i_height));
            this._ref_buf = i_buffer;
            this._reader = new NyARRgbPixelReader_RGB24(i_buffer, this._size);
            this._buffer_reader = new NyARBufferReader(i_buffer, INyARBufferReader.BUFFERFORMAT_BYTE1D_R8G8B8_24);
            return;
        }
        public INyARRgbPixelReader getRgbPixelReader()
        {
            return this._reader;
        }
        public INyARBufferReader getBufferReader()
        {
            return this._buffer_reader;
        }
    }
}