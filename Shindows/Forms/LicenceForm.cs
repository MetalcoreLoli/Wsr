using Shindows.DomainLogic;
using Shindows.Models;
using Shindows.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shindows.Forms
{
    public partial class LicenceForm : Form
    {
        private readonly LicenceController _controller;
        public LicenceForm()
        {
            InitializeComponent();
            _controller = new LicenceController(new StandartDialogService()); 
        }

      
    }
}
