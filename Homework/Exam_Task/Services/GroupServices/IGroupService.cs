using Exam_Task.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exam_Task.Services.GroupServices
{
	public interface IGroupService
	{
		Task Create(GroupEntity group);
		Task<List<GroupEntity>> GetAll();
		Task<GroupEntity> GetById(int id);
		Task Update(GroupEntity group);
	}
}
