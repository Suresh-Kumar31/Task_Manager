using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TaskManager.Entities;

namespace TaskManager
{
    public partial class index : System.Web.UI.Page
    {
        enum TaskCompletioStatus
        {
            Pending,
            Assigned,
            InProgress,
            Completed
        };
        
        public static DateTime selectedDate{ get; set; }
        public static int hour { get; set; }
        public static int min { get; set; }
        public List<int> HourList= new List<int> { 00, 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
        public List<int> MinList= new List<int> { 00, 05, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.DataSource = Enum.GetNames(typeof(TaskCompletioStatus));
            DropDownList1.DataBind();
            DropDownList2.DataSource = HourList;
            DropDownList2.DataBind();
            DropDownList3.DataSource = MinList;
            DropDownList3.DataBind();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            selectedDate = Calendar1.SelectedDate;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TaskManagerContext taskManagerContext = new TaskManagerContext();
            Task task = new Task()
            {
                createdDate = DateTime.Now,
                DueDate = selectedDate.AddHours(hour).AddMinutes(min),
                taskSubject = TextBox2.Text,
                taskCompletionStatus = DropDownList1.SelectedIndex  
            };
            taskManagerContext.Tasks.Add(task);
            taskManagerContext.SaveChanges();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            hour = Convert.ToInt16(HourList[DropDownList2.SelectedIndex]);
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            min = Convert.ToInt16(HourList[DropDownList3.SelectedIndex]);
        }
    }
}