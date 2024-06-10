﻿using CairoDesktop.Application.Interfaces;
using CairoDesktop.Application.Structs;
using CairoDesktop.Common.Localization;
using ManagedShell.Common.Helpers;
using System.Collections.Generic;

namespace CairoDesktop.Commands
{
    public class LockCommand : ICairoCommand
    {
        public ICairoCommandInfo Info => _info;

        private readonly LockCommandInfo _info = new LockCommandInfo();

        public void Setup() { }

        public bool Execute(List<CairoCommandParameter> parameters)
        {
            ShellHelper.Lock();

            return true;
        }

        public void Dispose() { }
    }

    public class LockCommandInfo : ICairoCommandInfo
    {
        public string Identifier => "Lock";

        public string Description => "Locks the workstation.";

        public string Label => DisplayString.sCairoMenu_Lock;

        public bool IsAvailable => true;

        public IReadOnlyCollection<CairoCommandParameter> Parameters => null;
    }
}
