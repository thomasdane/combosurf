using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ComboSurf.Domain.Models;

namespace ComboSurf.Domain.Services
{
	public interface IReportService
	{
	}
}


/*
 * a core folder. this is like a framework for each project. core should be re-usable. 
 * entities have ids. value objects do not.
 * internal is only for project, public is for whole solution
 * entity/model is singular. because about an object/instance
 * contstructur ctor and tab
 * guid factory method vs new guid
 * factory method returns back a new object
*/