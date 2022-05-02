using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanosGithub.View
{
    public interface IEmployeeView
    {
		string EmployeeId { get; set; }
		string EmployeeName { get; set; }
		string EmployeeGithub { get; set; }
		string EmployeeLinkedin { get; set; }
		string EmployeeFone { get; set; }
		DateTime EmployeeBirthDay { get; set; }
		string SearchValue { get; set; }
		bool IsEdit { get; set; }
		bool IsSuccessful { get; set; }
		string Message { get; set; }

		event EventHandler SearchEvent;
		event EventHandler AddNewEvent;
		event EventHandler EditEvent;
		event EventHandler DeleteEvent;
		event EventHandler SaveEvent;
		event EventHandler CancelEvent;
		event EventHandler GetGithubApi;
		void SetEmployeeListBindingSource(BindingSource employeeList);
		void Show();
	}
}
