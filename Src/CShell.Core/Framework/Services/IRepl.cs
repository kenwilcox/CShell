﻿#region License
// CShell, A Simple C# Scripting IDE
// Copyright (C) 2013  Arnova Asset Management Ltd., Lukas Buhler
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Media;
using ScriptCs.Contracts;

namespace CShell.Framework.Services
{
    public interface IRepl
    {
        void Initialize(IReplExecutor replExecutor);

        void EvaluateStarted(string input, string sourceFile);
        void EvaluateCompleted(ScriptResult result);

        bool IsEvaluating { get; }

        bool ShowConsoleOutput { get; set; }
        void Write(string text);
        void WriteLine();
        void WriteLine(string text);
        void Clear();

        string Font { get; set; }
        double FontSize { get; set; }
        Color BackgroundColor { get; set; }
        Color OutputColor { get; set; }
        Color WarningColor { get; set; }
        Color ErrorColor { get; set; }
        Color ReplColor { get; set; }
        void ResetColor();

        IEnumerable<string> SuppressedWarnings { get; }
        void SuppressWarning(string warningCode);
        void ShowWarning(string warningCode);
    }
}
