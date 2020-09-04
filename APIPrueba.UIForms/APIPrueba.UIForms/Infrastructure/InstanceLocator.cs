using APIPrueba.UIForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIPrueba.UIForms.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel main { get; set; }

        public InstanceLocator()
        {
            this.main = new MainViewModel();
        }
    }
}
