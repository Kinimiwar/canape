//    CANAPE Network Testing Tool
//    Copyright (C) 2014 Context Information Security
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Windows.Forms;
using CANAPE.Forms;

namespace CANAPE.Extension
{
    /// <summary>
    /// Interface for a main form menu extension
    /// </summary>
    public interface IMainFormMenuExtension
    {
        /// <summary>
        /// Execute the main for menu extension
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="menu"></param>
        void Execute(MainForm mainForm, ToolStripMenuItem menu);
    }
}
