using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Lab9._1.CourseManager
{
    public partial class CourseViewer : Form
    {
        private SchoolEntities school1Context;
        public CourseViewer()
        {
            InitializeComponent();
        }

        //Form Load
        private void CourseViewer_Load(object sender, EventArgs e)
        {
            school1Context = new SchoolEntities();

            var departments =
                from d in school1Context.Departments.Include("Courses")
                orderby d.Name
                select d;

            //var departments1 = school1Context.Departments.Include(x => x.Courses).OrderBy(x => x.Name);

            try
            {
                this.comboBoxDepartmentList.DisplayMember = "Name";
                this.comboBoxDepartmentList.DataSource = departments.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxDepartmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Department department =
                    (Department)this.comboBoxDepartmentList.SelectedItem;

                dataGridViewCourse.DataSource = department.Courses.ToList();

                dataGridViewCourse.Columns["Department"].Visible = false;
                dataGridViewCourse.Columns["StudentGrades"].Visible = false;
                dataGridViewCourse.Columns["OnlineCourse"].Visible = false;
                dataGridViewCourse.Columns["OnsiteCourse"].Visible = false;
                dataGridViewCourse.Columns["People"].Visible = false;
                dataGridViewCourse.Columns["DepartmentId"].Visible = false;

                dataGridViewCourse.AutoResizeColumn((int)DataGridViewAutoSizeColumnMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                school1Context.SaveChanges();
                MessageBox.Show("Changes saved to database.");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
            school1Context.Dispose();
        }
    }
}
