/*
 * Copyright (C) 2011 D3Sharp Project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;

namespace D3Sharp.Net
{    
    public class ConnectionEventArgs : EventArgs
    {
        public IConnection Connection { get; private set; }

        public ConnectionEventArgs(IConnection connection)
        {
            if (connection == null)
                throw new ArgumentNullException("connection");
            this.Connection = connection;
        }

        public override string ToString()
        {
            return Connection.RemoteEndPoint != null
                ? Connection.RemoteEndPoint.ToString()
                : "Not Connected";
        }
    }
}
