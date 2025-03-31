using TodoAppWPF;
namespace TestingToDoList
{
    public class ToDoListTests
    {
        private TodoList _todoList;

        public ToDoListTests()
        {
            _todoList = new TodoList();
        }
        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            var task = "Test task";
            _todoList.AddTask(task);
            var tasks = _todoList.GetAllTasks();
            Assert.Contains(task, tasks);
        }
        [Fact]
        public void RemoveTask_ShouldRemoveTaskToList()
        {
            var task = "Test task";
            _todoList.AddTask(task);
            _todoList.RemoveTask(0);
            var tasks = _todoList.GetAllTasks();
            Assert.DoesNotContain(task, tasks);
        }
        [Fact]
        public void RemoveTask_InvalidIndex_ShouldNotThrowException()
        {
            var task = "Valid task";
            _todoList.AddTask(task);
            _todoList.RemoveTask(10); //Ett Invalid index
            var tasks = _todoList.GetAllTasks();
            Assert.Single(tasks); //Kontrollerar att listan innehåller bara en enda element av typen
        }
    }
}