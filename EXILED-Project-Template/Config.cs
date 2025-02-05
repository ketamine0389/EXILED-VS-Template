// EXILED Project Template
// Version 1
// https://github.com/ketamine0389

namespace EXILED_Project_Template
{
    using System.Collections.Generic;
    using System.ComponentModel;

    using Exiled.API.Interfaces;
    
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = true;
    }
}
