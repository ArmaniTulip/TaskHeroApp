using System;
using System.Collections;
using Systems.Collections.Generic;
using System.Linq
using System.Text;
using System.Threading.Tasks;
using TaskHeroApp.Model;

namespace TaskHeroApp.Data;


internal class DataSource
{
	public static List<Task> TaskList;
	public static List<User> UserList;

  public static void CreateData()
  { 
	TaskList = new List<Task>();
		{
			new TaskList() { taskName = "Register Vehicle", dueDate = DateTime.Now, priorityLevel = "Low", energyNecessary = "Medium", expectedTimeToComplete = "1 Hour" }
		}

	UserList = new List<User>();
		{
			new UserList() { userName = "Jreed1021", password = "password123" }
		}

}
}