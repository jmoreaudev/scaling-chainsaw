using Sample.Data.Models;
using Sample.Data.Stores;
using Sample.Ui.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample.Ui.Instructors
{
    public partial class InstructorHomeControl : UserControl
    {
        public InstructorHomeControl(IControlParent controlParent, int id)
        {
            InitializeComponent();

            instructorStore = StoreFactory.BuildInstructorStore();
            instructor = instructorStore.GetInstructorById(id);

            ShowInstructorBasicInfo();
        }

        private readonly IInstructorStore instructorStore;
        private readonly Instructor instructor;

        private void ShowInstructorBasicInfo()
        {
            InstructorName.Text = instructor.Name;
            InstructorEmail.Text = instructor.Email;
            InstructorTelephone.Text = instructor.Telephone;
        }
    }
}
