using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPos.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private BindableCollection<Order> _order = new BindableCollection<Order>();
    }
    public ShellViewModel()
    {
        
    }
}
