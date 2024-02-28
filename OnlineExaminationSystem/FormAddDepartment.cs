using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineExaminationSystem
{
    public partial class FormAddDepartment : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();
        public FormAddDepartment()
        {
            InitializeComponent();
        }

        private void FormAddDepartment_Load(object sender, EventArgs e)
        {
            var Inst = (from I in _context.Instructors 
                         select new 
                         { 
                             I.Id,
                             FullNamee = I.Fname + " " + I.Lname 
                         }).ToList();
            cmb_Mgr.DataSource = Inst;
            cmb_Mgr.DisplayMember = "FullNamee";
            cmb_Mgr.ValueMember = "Id";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string msg = "";
            int InstId = (int)cmb_Mgr.SelectedValue;

            if (txt_DeptName.Text.Length == 0)
            {
                flag = false;
                msg = "Please Enter Department Name";
            }
            else
            {
                var result = _context.Database.ExecuteSql($"exec SP_InsertIntoDepartment {txt_DeptName.Text},{InstId}");
                if (result == 0 || flag == false)
                {
                    msg = "Something Went Wrong";
                }
                else
                {
                    MessageBox.Show("Department Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if(msg.Length > 0)
            {
                MessageBox.Show(msg,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
